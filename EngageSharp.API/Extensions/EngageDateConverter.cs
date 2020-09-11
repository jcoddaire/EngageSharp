using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace EngageSharp.Extensions
{
    /// <summary>
    /// Engage has UNIX DateTime values. So here's where we convert them into something C# can handle.
    /// </summary>
    public class EngageDateConverter : DateTimeConverterBase
    {
        private static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(((DateTime)value - _epoch).TotalMilliseconds + "000");
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>
        /// The object value.
        /// </returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null) 
            { 
                return null; 
            }
            if (string.IsNullOrWhiteSpace(reader.Value.ToString()))
            {
                return null;
            }
            return _epoch.AddMilliseconds(Convert.ToInt64(reader.Value.ToString()));
        }
        
    }
}

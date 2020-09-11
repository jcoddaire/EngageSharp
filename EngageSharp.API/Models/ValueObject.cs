using EngageSharp.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngageSharp.Models
{
    public class ValueObject
    {
        [JsonProperty("value")]
        public object Value { get; set; } // could be a string, number, or UNIX date.

        [JsonProperty("lastModified")]
        [JsonConverter(typeof(EngageDateConverter))]
        public DateTime? LastModified { get; set; }
    }
}

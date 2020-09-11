using EngageSharp.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngageSharp.Models
{
    public class DateObject
    {
        [JsonProperty("value")]
        [JsonConverter(typeof(EngageDateConverter))]
        public DateTime? Value { get; set; }

        [JsonProperty("lastModified")]
        [JsonConverter(typeof(EngageDateConverter))]
        public DateTime? LastModified { get; set; }
    }
}

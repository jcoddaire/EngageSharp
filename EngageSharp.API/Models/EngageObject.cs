using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngageSharp.Models
{
    public class EngageObject<T>
    {
        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("items")]
        public List<T> Items { get; set; }
    }
}

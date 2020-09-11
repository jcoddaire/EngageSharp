using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngageSharp.Models.Organization
{
    public class Category
    {
        [JsonProperty("categoryId")]
        public int ID { get; set; }

        [JsonProperty("categoryName")]
        public string Name { get; set; }
    }
}

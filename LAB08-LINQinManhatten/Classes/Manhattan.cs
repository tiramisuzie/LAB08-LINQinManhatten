using Newtonsoft.Json;
using System.Collections.Generic;

namespace LAB08_LINQinManhatten.Classes
{
    class Manhattan
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("features")]
        public List<Feature> Features { get; set; }
    }
}

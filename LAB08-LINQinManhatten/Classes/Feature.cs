using Newtonsoft.Json;

namespace LAB08_LINQinManhatten.Classes
{
    class Feature
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }
}

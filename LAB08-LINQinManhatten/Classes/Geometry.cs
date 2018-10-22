using Newtonsoft.Json;

namespace LAB08_LINQinManhatten.Classes
{
    class Geometry
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
        
    }
}

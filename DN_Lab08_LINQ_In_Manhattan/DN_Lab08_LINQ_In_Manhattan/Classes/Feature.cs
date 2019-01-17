using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace DN_Lab08_LINQ_In_Manhattan.Classes
{
    public class Feature
    {
        [JsonProperty("type")]
        public FeatureType Type { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }

    }
}

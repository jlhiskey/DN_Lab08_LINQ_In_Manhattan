using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DN_Lab08_LINQ_In_Manhattan.Classes
{
    class AllFeatures
    {
        public partial class Instruction
        {
            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("features")]
            public List<Feature> Features { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DN_Lab08_LINQ_In_Manhattan.Classes
{
    public class AllFeatures
    {

            [JsonProperty("features")]
            public List<Feature> Features { get; set; }
    }
}

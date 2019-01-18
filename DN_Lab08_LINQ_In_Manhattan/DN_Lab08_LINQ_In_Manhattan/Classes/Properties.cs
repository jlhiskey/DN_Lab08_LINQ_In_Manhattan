using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DN_Lab08_LINQ_In_Manhattan.Classes
{
    public class Properties
    {
        [JsonProperty("zip")]
        public long Zip { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("borough")]
        public string Borough { get; set; }

        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }
    }
}

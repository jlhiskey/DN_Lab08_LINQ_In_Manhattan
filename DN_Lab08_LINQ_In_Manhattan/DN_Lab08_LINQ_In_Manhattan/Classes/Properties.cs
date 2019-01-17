using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DN_Lab08_LINQ_In_Manhattan.Classes
{
    class Properties
    {
        public enum CityE { NewYork };
        public enum StateE { Ny };
        public enum BoroughE { Manhattan };
        public enum CountyE { NewYorkCounty };

        [JsonProperty("zip")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Zip { get; set; }

        [JsonProperty("city")]
        public CityE City { get; set; }

        [JsonProperty("state")]
        public StateE State { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("borough")]
        public BoroughE Borough { get; set; }

        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("county")]
        public CountyE County { get; set; }
    }
}

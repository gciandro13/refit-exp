using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Refit.Mvc.Model_Refit
{
    public class RenderRequest
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }


    public record ResponseNameAge
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}

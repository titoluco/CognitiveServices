using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveServices.Model
{
    public class Videos
    {
        [JsonProperty("webSearchUrl")]
        public string WebSearchUrl { get; set; }
    }
}

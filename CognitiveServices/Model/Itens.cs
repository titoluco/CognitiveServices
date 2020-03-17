using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveServices.Model
{
    public class Itens
    {
        //[JsonProperty("rectangle")]
        //public Rectangle rectangle { get; set; }

        [JsonProperty("object")]
        public string item { get; set; }

        //[JsonProperty("confidence")]
        //public decimal confidence { get; set; }

        //[JsonProperty("parent")]
        //public Parent parent { get; set; }
    }
}

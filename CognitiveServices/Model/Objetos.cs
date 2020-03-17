using Newtonsoft.Json;
using System.Collections.Generic;
namespace CognitiveServices.Model
{
    public class Objetos
    {
        [JsonProperty("objects")]
        public List<Itens> objects { get; set; }
    }

}

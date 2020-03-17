using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveServices.Model
{
    public class Retorno
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public List<Links> Links { get; set; }
    }

    public class Links
    {
        public string PalavraChave { get; set; }
        public string url { get; set; }
    }
}

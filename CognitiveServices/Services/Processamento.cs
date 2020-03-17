using CognitiveServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognitiveServices.Services
{
    public class Processamento
    {
        public async Task<Retorno> PesquisaAsync(string ComputerVisionKey, string BingVideoSearchKey, string imageUrl)
        {
            Retorno ret = new Retorno();            

            try
            {
                Objetos obj = await DetectObjects.Detectar(imageUrl, ComputerVisionKey);

                ret.Links = new List<Links>();                

                foreach (var item in obj.objects)
                {
                    Links link = new Links();
                    link.PalavraChave = item.item;
                    Videos videos = SearchVideos.Pesquisar(BingVideoSearchKey, item.item);
                    link.url = videos.WebSearchUrl;
                    ret.Links.Add(link);
                }
                ret.Mensagem = "";
                ret.Sucesso = true;
            }
            catch (Exception ex)
            {
                ret.Mensagem = ex.Message;
                ret.Sucesso = false;
                ret.Links = null;                
            }
            return ret;
        }

    }
}

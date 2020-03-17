using CognitiveServices.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveServices.Services
{
    public static class SearchVideos
    {
        static string endpoint = "https://api.cognitive.microsoft.com/bing/v7.0/videos/search";

        public static Videos Pesquisar(string BingVideoSearchKey, string palavraChave)
        {
            try
            {
                var uriQuery = endpoint + "?q=" + Uri.EscapeDataString(palavraChave);

                WebRequest request = HttpWebRequest.Create(uriQuery);
                request.Headers["Ocp-Apim-Subscription-Key"] = BingVideoSearchKey;
                HttpWebResponse response = (HttpWebResponse)request.GetResponseAsync().Result;
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return JsonConvert.DeserializeObject<Videos>(json);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

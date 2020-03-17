using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CognitiveServices.Model;
using Newtonsoft.Json;

namespace CognitiveServices.Services
{
    public static class DetectObjects
    {
        static string endpoint = "https://westcentralus.api.cognitive.microsoft.com/vision";

        public static async Task<Objetos> Detectar(string imageUrl, string subscriptionKey)
        {
            if (!Uri.IsWellFormedUriString(imageUrl, UriKind.Absolute))
            {                
                throw new Exception($"URL inválida: {imageUrl}");
            }
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                string uri = $"{endpoint}/v2.0/detect";

                string requestBody = " {\"url\":\"" + imageUrl + "\"}";
                var content = new StringContent(requestBody);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await client.PostAsync(uri, content);
                string contentString = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Objetos>(contentString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

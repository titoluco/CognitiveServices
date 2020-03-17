using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CognitiveServices.Services;
using CognitiveServices.Model;
using System.Text.Json;

namespace CognitiveServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PesquisaController : ControllerBase
    {
        /// <summary>
        /// Realiza uma busca de vídeos no Bing pelos objetos identificados na imagem enviada
        /// </summary>
        /// <param name="ComputerVisionKey"></param>   
        /// <param name="BingVideoSearchKey"></param>   
        /// <param name="imageUrl"></param> 
        [Produces("application/json")]
        [HttpGet("video")]
        public async Task<Retorno> GetAsync(string ComputerVisionKey, string BingVideoSearchKey, string imageUrl)
        {
            Processamento processamento = new Processamento();

            return await processamento.PesquisaAsync(ComputerVisionKey, BingVideoSearchKey, imageUrl);
        }

    }
}

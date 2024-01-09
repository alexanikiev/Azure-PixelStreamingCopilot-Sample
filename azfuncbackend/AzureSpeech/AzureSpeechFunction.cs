using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Demo.Function
{
    public class AzureSpeechFunction
    {
        private readonly AzureSpeechService _speechService;

        public AzureSpeechFunction(AzureSpeechService speechService)
        {
            _speechService = speechService;
        }

        [FunctionName("GetAzureSpeechToken")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "azurespeech/token")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Received a request to retrieve Azure Speech token.");

            var token = await _speechService.FetchTokenAsync();
            if (!string.IsNullOrEmpty(token))
            {
                return new OkObjectResult(token);
            }

            return new BadRequestObjectResult("Unable to retrieve the token");
        }
    }
}

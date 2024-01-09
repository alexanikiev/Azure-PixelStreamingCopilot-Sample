using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Demo.Function
{
    public class AzureOpenAIFunction
    {
        private readonly AzureOpenAIService _azureOpenAIService;

        public AzureOpenAIFunction(AzureOpenAIService azureOpenAIService)
        {
            _azureOpenAIService = azureOpenAIService;
        }

        [FunctionName("GenerateAzureOpenAIResponse")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "azureopenai/generate")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Received a request to generate Azure OpenAI response.");

            dynamic request = JsonConvert.DeserializeObject(await new StreamReader(req.Body).ReadToEndAsync());
            var response = await _azureOpenAIService.SubmitRequestToAzureOpenAI(request);
            return new OkObjectResult(response);
        }
    }
}

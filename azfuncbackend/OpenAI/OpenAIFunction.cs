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
    public class OpenAIFunction
    {
        private readonly OpenAIService _openAIService;

        public OpenAIFunction(OpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        [FunctionName("GenerateOpenAIResponse")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "openai/generate")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Received a request to generate OpenAI response.");

            dynamic request = JsonConvert.DeserializeObject(await new StreamReader(req.Body).ReadToEndAsync());
            var response = await _openAIService.SubmitRequestToOpenAI(request);
            return new OkObjectResult(response);
        }
    }
}

using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Web;

public class AzureOpenAIService
{
    private readonly HttpClient _httpClient;
    private readonly string _endpointUrl;
    private readonly string _apiKey;

    public AzureOpenAIService(HttpClient httpClient)
    {
        _httpClient = httpClient;

        _endpointUrl = Environment.GetEnvironmentVariable("AZUREOPENAI_ENDPOINT_URL");
        _apiKey = Environment.GetEnvironmentVariable("AZUREOPENAI_API_KEY");

        _httpClient.DefaultRequestHeaders.Add("api-key", $"{_apiKey}");
    }

    public async Task<string> SubmitRequestToAzureOpenAI(dynamic request)
    {
        string question = request?.question?.ToString();
        question = SanitizeInput(question) ?? "How are you today?";

        string systemMessage = @"Your system message";

        var jsonRequest = $@"{{
            ""messages"": [
            {{
                ""role"":""system"",
                ""content"":""{systemMessage.Replace("\n", "\\n")}""
            }}, 
            {{
                ""role"": ""user"",
                ""content"": ""{question}""
            }}
            ],
            ""max_tokens"": 800,
            ""temperature"": 0.7,
            ""frequency_penalty"": 0,
            ""presence_penalty"": 0,
            ""top_p"": 0.95,
            ""stop"": null
        }}";

        var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(_endpointUrl, content);
        response.EnsureSuccessStatusCode();

        var jsonResponse = await response.Content.ReadAsStringAsync();
        return ExtractContentFromAzureOpenAIResponse(jsonResponse);
    }

    private string SanitizeInput(string input)
    {
        return HttpUtility.HtmlEncode(input);
    }

    private string ExtractContentFromAzureOpenAIResponse(string jsonResponse)
    {
        var responseObject = JObject.Parse(jsonResponse);

        if (responseObject["choices"] != null && responseObject["choices"].Any())
        {
            var answer = responseObject["choices"][0]["message"]["content"].ToString();

            if (!string.IsNullOrEmpty(answer))
            {
                var resultObject = new { result = answer };
                return JsonConvert.SerializeObject(resultObject);
            }
        }

        return null;
    }
}
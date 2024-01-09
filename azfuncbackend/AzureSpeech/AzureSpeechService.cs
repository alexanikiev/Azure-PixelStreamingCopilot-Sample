using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;

public class AzureSpeechService
{
    private readonly HttpClient _httpClient;
    private readonly string _serviceRegion;
    private readonly string _subscriptionKey;

    public AzureSpeechService(HttpClient httpClient)
    {
        _httpClient = httpClient;

        _serviceRegion = Environment.GetEnvironmentVariable("AZURESPEECH_SERVICE_REGION");
        _subscriptionKey = Environment.GetEnvironmentVariable("AZURESPEECH_SUBSCRIPTION_KEY");

        _httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{_subscriptionKey}");
    }

    public async Task<string> FetchTokenAsync()
    {
        var tokenUrl = $"https://{_serviceRegion}.api.cognitive.microsoft.com/sts/v1.0/issueToken";

        var response = await _httpClient.PostAsync(tokenUrl, null);
        if (response.IsSuccessStatusCode)
        {
            var token = await response.Content.ReadAsStringAsync();
            var tokenObject = new { token, region = _serviceRegion };
            return JsonConvert.SerializeObject(tokenObject);
        }
        return null;
    }
}

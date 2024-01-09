using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Demo.Function 
{
    public class OpenAIService
    {
        private readonly HttpClient _httpClient;

        private readonly string _endpointUrl;
        private readonly string _authToken;

        public OpenAIService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _endpointUrl = Environment.GetEnvironmentVariable("OPENAI_ENDPOINT_URL");
            _authToken = Environment.GetEnvironmentVariable("OPENAI_AUTH_TOKEN");

            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_authToken}");
        }

        public async Task<string> SubmitRequestToOpenAI(dynamic request)
        {
            #region Sample Image
            string defaultBase64Image = "data:image/png;base64, your base64 image";
            #endregion

            string base64Image = request?.image?.ToString() ?? defaultBase64Image;

            if (!IsValidBase64(base64Image))
            {
                return null;
            }

            string systemMessage = @"Your system message";

            var jsonRequest = $@"
            {{
                ""model"": ""gpt-4-vision-preview"",
                ""messages"": [
                {{
                    ""role"": ""system"",
                    ""content"": ""{systemMessage.Replace("\n", "\\n")}""
                }},
                {{
                    ""role"": ""user"",
                    ""content"": [
                    {{
                        ""type"": ""text"",
                        ""text"": ""Please explain what's depicted on this image?""
                    }},
                    {{
                        ""type"": ""image_url"",
                        ""image_url"": {{
                            ""url"": ""{base64Image}""
                        }}
                    }}
                    ]
                }}
                ],
                ""max_tokens"": 300
            }}";

            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_endpointUrl, content);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return ExtractContentFromOpenAIResponse(jsonResponse);
        }

        private bool IsValidBase64(string base64String)
        {
            if (string.IsNullOrEmpty(base64String)) {
                return false;
            }

            const string prefix = "data:image/png;base64,";
            if (base64String.StartsWith(prefix)) {
                base64String = base64String.Substring(prefix.Length);
            }

            if (base64String.Length % 4 != 0) {
                return false;
            }

            base64String = base64String.Replace('-', '+').Replace('_', '/');

            if (base64String.Any(c => !char.IsLetterOrDigit(c) && c != '+' && c != '/' && c != '=')) {
                return false;
            }

            try
            {
                Convert.FromBase64String(base64String);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        
        private string ExtractContentFromOpenAIResponse(string jsonResponse)
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
}
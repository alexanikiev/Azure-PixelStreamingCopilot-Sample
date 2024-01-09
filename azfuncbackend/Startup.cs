using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Demo.Function.Startup))]

namespace Demo.Function
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            // Add HttpClient
            builder.Services.AddHttpClient();

            // Add AzureOpenAIService
            builder.Services.AddScoped<AzureOpenAIService>();

            // Add AzureSpeechService
            builder.Services.AddScoped<AzureSpeechService>();

            // Add OpenAIService
            builder.Services.AddScoped<OpenAIService>();
        }
    }
}
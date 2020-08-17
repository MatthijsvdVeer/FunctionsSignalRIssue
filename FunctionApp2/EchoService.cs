using Microsoft.Extensions.Logging;

namespace FunctionApp2
{
    public sealed class EchoService : IEchoService
    {
        private readonly ILogger<EchoService> logger;

        public EchoService(ILogger<EchoService> logger) => this.logger = logger;

        public string Echo(string text)
        {
            this.logger.LogInformation($"Echoing: {text}");
            return text;
        }
    }
}
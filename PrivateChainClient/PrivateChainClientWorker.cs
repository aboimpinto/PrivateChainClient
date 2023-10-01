using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PrivateChainClient
{
    public class PrivateChainClientWorker : BackgroundService
    {
        private readonly ILogger<PrivateChainClientWorker> _logger;
        
        public PrivateChainClientWorker(ILogger<PrivateChainClientWorker> logger)
        {
            this._logger = logger;

        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            this._logger.LogInformation("PrivateChainClient Worker started...");

            return Task.CompletedTask;
        }
    }
}
using System.Net.Sockets;
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

            var client = new TcpClient();
            client.Connect("PrivateChain_Server", 4566);
            Console.WriteLine("Connected to server...");


            return Task.CompletedTask;
        }
    }
}
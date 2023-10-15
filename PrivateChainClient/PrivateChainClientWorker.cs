using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RPC.Model;

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

            var stream = client.GetStream();

            var handshake = new HandshakeCommand();
            handshake.InputParameters.NodeType = NodeType.GovernanceNode;
            handshake.InputParameters.NodeId = "nodeId";
            handshake.InputParameters.NodeResposablieAddress = "nodeResposablieAddress";

            var jsonOptions = new JsonSerializerOptions
            {
                Converters = { new CommandBaseConverter() }
            };
            var jsonHandshake = JsonSerializer.Serialize(handshake, jsonOptions);

            // var xxx = JsonSerializer.Deserialize<HandshakeCommand>(jsonHandshake, jsonOptions);

            var handshakeRequestBytes = Encoding.ASCII.GetBytes(jsonHandshake);
            stream.Write(handshakeRequestBytes, 0, handshakeRequestBytes.Length);

            return Task.CompletedTask;
        }
    }
}
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Olimpo;
using Olimpo.RPC.Model;

namespace PrivateChainClient
{
    public class PrivateChainClientWorker : BackgroundService
    {
        private readonly IBootstrapperManager _bootstrapperManager;
        private readonly ILogger<PrivateChainClientWorker> _logger;
        
        public PrivateChainClientWorker(
            IBootstrapperManager bootstrapperManager,
            ILogger<PrivateChainClientWorker> logger)
        {
            this._bootstrapperManager = bootstrapperManager;
            this._logger = logger;

        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            this._logger.LogInformation("PrivateChainClient Worker started...");

            this._bootstrapperManager.StartBootstrappableModules();

            // var client = new TcpClient();
            // client.Connect("PrivateChain_Server", 4566);
            // Console.WriteLine("Connected to server...");

            // var stream = client.GetStream();

            // var listeningThread = new Thread(new ParameterizedThreadStart(this.StartListening));
            // listeningThread.Start(stream);

            // var handshake = new HandshakeCommand();
            // handshake.InputParameters.NodeType = NodeType.GovernanceNode;
            // handshake.InputParameters.NodeId = "nodeId";
            // handshake.InputParameters.NodeResposablieAddress = "nodeResposablieAddress";

            // var jsonOptions = new JsonSerializerOptions
            // {
            //     Converters = { new CommandBaseConverter() }
            // };
            // var jsonHandshake = JsonSerializer.Serialize(handshake, jsonOptions);

            // var handshakeRequestBytes = Encoding.ASCII.GetBytes(jsonHandshake);
            // stream.Write(handshakeRequestBytes, 0, handshakeRequestBytes.Length);

            return Task.CompletedTask;
        }

        // private void StartListening(object obj)
        // {
        //     byte[] buffer = new byte[256];;
        //     string data;
        //     var position = 0;

        //     var stream = (NetworkStream)obj;

        //     while(true)
        //     {
        //         while((position = stream.Read(buffer, 0, buffer.Length)) != 0)
        //         {
        //             data = Encoding.UTF8.GetString(buffer, 0, position);
        //         }
        //     }
        // }
    }
}
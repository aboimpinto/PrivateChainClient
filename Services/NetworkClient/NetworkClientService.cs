
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Olimpo.RPC.Model;
using TcpOlimpoClient.Manager;

namespace NetworkClient;

public class NetworkClientService : INetworkClientService
{
    private readonly IClient _client;
    private readonly ILogger<NetworkClientService> _logger;

    public NetworkClientService(
        IClient client, 
        ILogger<NetworkClientService> logger)
    {
        this._client = client;
        this._logger = logger;
    }

    public Task Start()
    {
        this._logger.LogInformation("Starting NetworkClient...");

        this._client.Start("PrivateChain_Server", 4566);

        var handshakeCommand = new HandshakeCommand();
        handshakeCommand.InputParameters.NodeType = NodeType.GovernanceNode;
        handshakeCommand.InputParameters.NodeId = "nodeId";
        handshakeCommand.InputParameters.NodeResposablieAddress = "nodeResposablieAddress";

        var jsonOptions = new JsonSerializerOptions
        {
            Converters = { new CommandBaseConverter() }
        };
        var jsonHandshake = JsonSerializer.Serialize(handshakeCommand, jsonOptions);
        this._client.Channel.Send(jsonHandshake);

        return Task.CompletedTask;
    }

    public void Stop()
    {
        this._logger.LogInformation("Stopping NetworkClient...");
    }
}

using Olimpo;

namespace NetworkClient;

public class NetworkClientBootstrapper : IBootstrapper
{
    public int Priority { get; set; } = 10;
        private readonly INetworkClientService _networkClientService;

    public NetworkClientBootstrapper(INetworkClientService networkClientService)
    {
        this._networkClientService = networkClientService;
    }

    public void Shutdown()
    {
        this._networkClientService.Stop();
    }

    public async Task Startup()
    {
        await this._networkClientService.Start();
    }
}

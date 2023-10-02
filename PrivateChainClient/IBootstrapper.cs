namespace PrivateChainClient;

public interface IBootstrapper
{
    int Priority { get; set; }

    Task Startup();

    void Shutdown();
}
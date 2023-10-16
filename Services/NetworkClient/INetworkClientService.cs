namespace NetworkClient;

public interface INetworkClientService
{
    Task Start();

    void Stop();
}

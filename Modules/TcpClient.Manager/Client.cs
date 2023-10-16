using System.Net;
using System.Net.Sockets;
using System.Reactive.Subjects;

namespace TcpOlimpoClient.Manager;

public class Client : IClient
{
    private TcpClient _tcpClient;
    
    public bool Running { get; set; }

    public Channel Channel { get; set ;}

    public Subject<DataReceivedArgs> DataReceived { get; }

    public Task Start(string address, int port)
    {
        try
        {
            this._tcpClient = new TcpClient();
            this._tcpClient.Connect(address, port);

            this.Channel = new Channel(this, this._tcpClient.GetStream());
        }
        catch(Exception ex)
        {
            throw;
        }
        
        return Task.CompletedTask;
    }

    public void Stop()
    {
        this._tcpClient.Dispose();
        this.Channel?.Dispose();
    }
}

using System.Net;
using System.Reactive.Subjects;

namespace TcpOlimpoClient.Manager;

public interface IClient
{
    bool Running { get; set; }

    Channel Channel { get; set ;}

    Subject<DataReceivedArgs> DataReceived { get; }

    Task Start(string address, int port);

    void Stop();
}
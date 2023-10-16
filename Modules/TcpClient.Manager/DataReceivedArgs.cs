namespace TcpOlimpoClient.Manager;

public class DataReceivedArgs
{
    public string Message { get; } = string.Empty;

    public DataReceivedArgs(string message)
    {
        this.Message = message;
    }
}

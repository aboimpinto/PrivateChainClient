namespace RPC.Model;

public class HandShakeCommandParameters
{
    public NodeType NodeType { get; set; }

    public string NodeId { get; set; }

    public string NodeResposablieAddress { get; set; }
}
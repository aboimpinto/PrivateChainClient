namespace RPC.Model;

public class HandshakeCommand : CommandBase
{
    public HandShakeCommandParameters InputParameters { get; set; }

    // public HandshakeCommand(NodeType nodeType, string nodeId, string nodeResposablieAddress)
    // {
    //     this.Command = "HandshakeCommand";
    //     this.InputParameters = new HandShakeCommandParameters
    //     {
    //         NodeType = nodeType,
    //         NodeId = nodeId,
    //         NodeResposablieAddress = nodeResposablieAddress
    //     };
    // } 

    public HandshakeCommand()
    {
        this.Command = "HandshakeCommand";
        this.InputParameters = new HandShakeCommandParameters();
    }
}

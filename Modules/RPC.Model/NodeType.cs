namespace RPC.Model;

public enum NodeType
{
    /// <summary>
    /// This node will not participate in the Governance of the Network. 
    /// Will receive sync notifications only.
    /// </summary>
    GatwayNode,         

    /// <summary>
    /// Will participate in the Governance of the Network. 
    /// Will the enrolled has a block producer ac cording with the network rules.
    /// </summary>
    GovernanceNode,    
}

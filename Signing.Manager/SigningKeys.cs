using System.Text;
using NBitcoin;

namespace Signing.Manager;

public class SigningKeys
{
    public string PublicAddress { get; }

    public string PrivateKey { get; }

    public SigningKeys()
    {
        var privateKey = new Key();
        var address = privateKey.PubKey.GetAddress(ScriptPubKeyType.SegwitP2SH, Network.Main);

        this.PublicAddress = Encoding.UTF8.GetString(Encoding.ASCII.GetBytes(address.ToString()));
        this.PrivateKey = privateKey.GetWif(Network.Main).ToString();
    }
}

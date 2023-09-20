using Encripting.Manager;
using Signing.Manager;

namespace PrivateChainClient;

public class Program
{
    public static void Main()
    {
        // Bitcoin Example
        var bitcoinActorAKeys = new SigningKeys();
        Console.WriteLine("Client A's Public Address: " + bitcoinActorAKeys.PublicAddress);
        Console.WriteLine("Client A's Private Key: " + bitcoinActorAKeys.PrivateKey);

        Console.WriteLine();

        var bitcoinActorBKeys = new SigningKeys();
        Console.WriteLine("Client B's Public Address: " + bitcoinActorBKeys.PublicAddress);
        Console.WriteLine("Client B's Private Key: " + bitcoinActorBKeys.PrivateKey);

        Console.WriteLine();

        // Encrypt Example
        // var rsaActorAKeys = new EncryptKeys();
        // Console.WriteLine("Hash: " + rsaActorAKeys.GetHashCode());
        // Console.WriteLine("Client A's Public Key: " + rsaActorAKeys.PublicKey);
        // Console.WriteLine();
        // Console.WriteLine("Client A's Private Key: " + rsaActorAKeys.PrivateKey);
        
        // Console.WriteLine();
        // Console.WriteLine();

        // var rsaActorBKeys = new EncryptKeys();
        // Console.WriteLine("Hash: " + rsaActorBKeys.GetHashCode());
        // Console.WriteLine("Client B's Public Key: " + rsaActorBKeys.PublicKey);
        // Console.WriteLine();
        // Console.WriteLine("Client B's Private Key: " + rsaActorBKeys.PrivateKey);
        // Console.WriteLine();
        // Console.WriteLine();

        // string message = "Hello Actor B";
        // var encryptedMessage = EncryptKeys.Encrypt(message, rsaActorBKeys.PublicKey);
        // Console.WriteLine("Message encrypted by Actor B public key: " + encryptedMessage);
        // Console.WriteLine();

        // var messageDecryptedByActorB = EncryptKeys.Decrypt(encryptedMessage, rsaActorBKeys.PrivateKey);
        // Console.WriteLine("Message decrypted by ActorB private key: " + messageDecryptedByActorB);
    }
}



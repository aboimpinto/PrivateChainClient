using System.Net;
using System.Net.Sockets;
using Encripting.Manager;
using Signing.Manager;

namespace PrivateChainClient;

public class Program
{
    public static void Main()
    {
        var client = new TcpClient();
        // client.Connect("localhost", 4566);
        // client.Connect("quirky_knuth", 4566);
        client.Connect("PrivateChain_Server", 4566);
        Console.WriteLine("Connected to server...");


        // // Bitcoin Example
        // var signingActorAKeys = new SigningKeys();
        // Console.WriteLine("Client A's Public Address: " + signingActorAKeys.PublicAddress);
        // Console.WriteLine("Client A's Private Key: " + signingActorAKeys.PrivateKey);

        // Console.WriteLine();

        // var signingActorBKeys = new SigningKeys();
        // Console.WriteLine("Client B's Public Address: " + signingActorBKeys.PublicAddress);
        // Console.WriteLine("Client B's Private Key: " + signingActorBKeys.PrivateKey);

        // Console.WriteLine();

        // var messageToSign = "Hello ActorB";
        // // Sign the message
        // string signature = SigningKeys.SignMessage(messageToSign, signingActorAKeys.PrivateKey);

        // // Verify the signature
        // bool isVerified = SigningKeys.VerifySignature(messageToSign, signature, signingActorAKeys.PublicAddress);

        // Console.WriteLine($"Message: {messageToSign}");
        // Console.WriteLine($"Signature: {signature}");
        // Console.WriteLine($"Signature verified: {isVerified}");

        // Console.WriteLine();
        // Console.WriteLine();
        // Console.WriteLine();



        // // Encrypt Example
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

        // string messageToEncrypt = "Hello Actor B";
        // var encryptedMessage = EncryptKeys.Encrypt(messageToEncrypt, rsaActorBKeys.PublicKey);
        // Console.WriteLine("Message encrypted by Actor B public key: " + encryptedMessage);
        // Console.WriteLine();

        // var messageDecryptedByActorB = EncryptKeys.Decrypt(encryptedMessage, rsaActorBKeys.PrivateKey);
        // Console.WriteLine("Message decrypted by ActorB private key: " + messageDecryptedByActorB);
    }
}



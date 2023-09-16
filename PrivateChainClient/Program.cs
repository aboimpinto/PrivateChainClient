using System.Security.Cryptography;
using System.Text;
using NBitcoin;

namespace PrivateChainClient;

public class Program
{
    public static void Main()
    {
        // // Generate a random Bitcoin key pair
        // var privateKey = new Key();
        // var address = privateKey.PubKey.GetAddress(ScriptPubKeyType.SegwitP2SH, Network.Main);

        // // Convert the Bitcoin address to a UTF-8 encoded string
        // string bitcoinAddressUtf8 = Encoding.UTF8.GetString(Encoding.ASCII.GetBytes(address.ToString()));

        // // Print the Bitcoin address
        // Console.WriteLine("Random Bitcoin Address (UTF-8 encoded): " + bitcoinAddressUtf8);

        // // Print the private key (in Wallet Import Format)
        // Console.WriteLine("Private Key (WIF): " + privateKey.GetWif(Network.Main));

        // // Print the public key
        // // Console.WriteLine("Public Key: " + privateKey.PubKey.ToHex());

        Console.WriteLine();


// Generate public and private keys for Client A
        using (var rsaA = new RSACryptoServiceProvider())
        {
            string publicKeyA = rsaA.ToXmlString(false);
            string privateKeyA = rsaA.ToXmlString(true);

            // Generate public and private keys for Client B
            using (var rsaB = new RSACryptoServiceProvider())
            {
                string publicKeyB = rsaB.ToXmlString(false);
                string privateKeyB = rsaB.ToXmlString(true);

                // // Client A sends an encrypted message to Client B
                // string messageFromA = "Hello, Client B!";
                // byte[] encryptedMessage = EncryptMessage(messageFromA, publicKeyB);

                // // Client B decrypts the received message
                // string decryptedMessage = DecryptMessage(encryptedMessage, privateKeyB);

                var base64StringA = Convert.ToBase64String(Encoding.UTF8.GetBytes(publicKeyA));
                var dataA = Convert.FromBase64String(base64StringA);
                var decodedPublicKeyA = Encoding.UTF8.GetString(dataA);

                Console.WriteLine("Client A's Public Key (original): " + publicKeyA);
                Console.WriteLine("Client A's Public Key (Base64): " + base64StringA);
                Console.WriteLine("Client A's Public Key (Convert-Back): " + decodedPublicKeyA);
                Console.WriteLine();
                Console.WriteLine("Client A's Private Key (original): " + privateKeyA);
                Console.WriteLine();
                Console.WriteLine("Client B's Public Key: " + publicKeyB);
                Console.WriteLine();
                // Console.WriteLine("Client A sends an encrypted message to Client B:");
                // Console.WriteLine("Encrypted Message: " + Convert.ToBase64String(encryptedMessage));
                // Console.WriteLine();
                // Console.WriteLine("Client B decrypts the received message:");
                // Console.WriteLine("Decrypted Message: " + decryptedMessage);
            }
        }


        // Generate random RSA keys for ActorA and ActorB

        // GenerateRandomRSAKeyPair(out RSAParameters actorAPublicKey, out RSAParameters actorAPrivateKey);
        // GenerateRandomRSAKeyPair(out RSAParameters actorBPublicKey, out RSAParameters actorBPrivateKey);

        // Console.WriteLine($"ActorA Public Address: {ConvertToBase64(actorAPublicKey)}");
        // Console.WriteLine($"ActorA Private Key: {ConvertToBase64(actorAPrivateKey)}");

        // Console.WriteLine();

        // Console.WriteLine($"ActorB Public Address: {ConvertToBase64(actorBPublicKey)}");
        // Console.WriteLine($"ActorB Private Key: {ConvertToBase64(actorBPrivateKey)}");

        // Generate an RSA key pair
        // using (RSA rsa = RSA.Create())
        // {
        //     // Get the public and private keys
        //     RSAParameters publicKeyRSA = rsa.ExportParameters(false);
        //     RSAParameters privateKeyRSA = rsa.ExportParameters(true);

        //     // Convert the public and private keys to Base64 strings
        //     string publicKeyBase64 = ConvertToBase64(publicKeyRSA);
        //     string privateKeyBase64 = ConvertToBase64(privateKeyRSA);

        //     Console.WriteLine("Public Key:");
        //     Console.WriteLine(publicKeyBase64);
        //     Console.WriteLine();

        //     Console.WriteLine("Private Key:");
        //     Console.WriteLine(privateKeyBase64);
        // }
    }

    public static void GenerateRandomRSAKeyPair(out RSAParameters publicKey, out RSAParameters privateKey)
    {
        using (RSA rsa = RSA.Create(512))
        {
            publicKey = rsa.ExportParameters(false);
            privateKey = rsa.ExportParameters(true);
        }
    }

    public static string ConvertToBase64(RSAParameters rsaParameters)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(
            $"{rsaParameters.Modulus.Length}:{Convert.ToBase64String(rsaParameters.Modulus)}:" +
            $"{Convert.ToBase64String(rsaParameters.Exponent)}");

        return Convert.ToBase64String(keyBytes);
    }
}



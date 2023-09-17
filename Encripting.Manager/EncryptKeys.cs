using System.Security.Cryptography;
using System.Text;

namespace Encripting.Manager;

public class EncryptKeys
{
    private string _publicKeyXml;
    private string _privateKeyXml;

    public string PublicKey { get; private set; }

    public string PrivateKey { get; private set; }

    public EncryptKeys()
    {
        using(var rsaKey = new RSACryptoServiceProvider())
        {
            this._publicKeyXml = rsaKey.ToXmlString(false);
            this._privateKeyXml = rsaKey.ToXmlString(true);

            this.PublicKey = Convert.ToBase64String(Encoding.UTF8.GetBytes(this._publicKeyXml));
            this.PrivateKey = Convert.ToBase64String(Encoding.UTF8.GetBytes(this._privateKeyXml));

            rsaKey.PersistKeyInCsp = false;
            rsaKey.Clear();
        } 
    }

    public static string Encrypt(string message, string publicKey)
    {
        using (var rsa = new RSACryptoServiceProvider())
        {
            var publicKeyBytes = Convert.FromBase64String(publicKey);
            var publicKeyXml = Encoding.UTF8.GetString(publicKeyBytes);

            rsa.FromXmlString(publicKeyXml);
            byte[] dataToEncrypt = Encoding.UTF8.GetBytes(message);
            return Convert.ToBase64String(rsa.Encrypt(dataToEncrypt, true));
        }
    }

    public static string Decrypt(string encryptedMessage, string privateKey)
    {
        using (var rsa = new RSACryptoServiceProvider())
        {
            var encryptedMessageBytes = Convert.FromBase64String(encryptedMessage);

            var privateKeyBytes = Convert.FromBase64String(privateKey);
            var privateKeyXml = Encoding.UTF8.GetString(privateKeyBytes);

            rsa.FromXmlString(privateKeyXml);
            byte[] decryptedData = rsa.Decrypt(encryptedMessageBytes, true);
            return Encoding.UTF8.GetString(decryptedData);
        }
    }
}

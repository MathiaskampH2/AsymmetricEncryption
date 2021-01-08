using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;
using System.Web;


namespace AsymmetricEncryption
{
    /// <summary>
    /// Class Rsa
    /// has the purpose of making an object of Rsa
    /// </summary>
    public class Rsa
    {
        // private variables of publicKey and privateKey
        private RSAParameters publicKey;
        private  RSAParameters privateKey;

 
        // method SafeKeysToXml runs GenerateKeys method based on the keyPaths from GetPublicKeyPath and GetPrivateKeyPath
        public void SafeKeysToXml( )
        {
            GenerateKeys(GetPublicKeyPath(), GetPrivateKeyPath());
        }

        // method GetPublicKeyPath returns the path of the publickey.xml file
        public string GetPublicKeyPath()
        {
            string publicKeyPath = null;
            return publicKeyPath = @".\keys\publicKey\publicKey.xml";
        }

        // GetPrivateKeyPath returns the path of the privatekey.xml file
        public string GetPrivateKeyPath()
        {
            string privateKeyPath = null;
                return privateKeyPath  = @".\keys\privateKey\privateKey.xml";
        }

        // GenerateKeys makes a privatekey and publickey and write their properties to an xml file.
        public  void GenerateKeys(string publicKeyPath, string privateKeyPath)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;

                if (File.Exists(privateKeyPath))
                {
                    File.Delete(privateKeyPath);
                }

                if (File.Exists(publicKeyPath))
                {
                    File.Delete(publicKeyPath);
                }

                File.WriteAllText(publicKeyPath, rsa.ToXmlString(false));
                File.WriteAllText(privateKeyPath, rsa.ToXmlString(true));
            }
        }

        // method EncryptData encrypts the data based on a byteArray given by userInput
        public  byte[] EncryptData(string publicKeyPath, byte[] dataToEncrypt)
        {
            // byte array to store the encrypted text
            byte[] encrypted;

            // using rsa 2048 bit
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                // read the publickey.xml
                rsa.FromXmlString(File.ReadAllText(publicKeyPath));
                // save the encrypted data in encrypted byte array
                encrypted = rsa.Encrypt(dataToEncrypt, false);
            }
            // return encrypted byte array
            return encrypted;
        }
        // method decryptData decrypts the data based on a byte array that has been encrypted by public key.
        public  byte[] DecryptData(string privateKeyPath, byte [] dataToDecrypt)
        {
            // byte array to store the decrypted text
            byte[] decrypted;
            // using rsa 2048 bit
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                // read the privatekey.xml
                rsa.FromXmlString(File.ReadAllText(privateKeyPath));
                // store the decrypted data in decrypted byte array
                decrypted = rsa.Decrypt(dataToDecrypt, false);
            }
            // return decrypted byte array
            return decrypted;
        }
    }
}
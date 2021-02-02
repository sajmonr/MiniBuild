using System.Runtime.CompilerServices;
using NETCore.Encrypt;

[assembly: InternalsVisibleTo("MiniBuild.Security.Tests")]
namespace MiniBuild.Security
{
    internal class Encryption : IEncryption
    {
        private readonly string _passphrase;
        public Encryption(string passphrase)
        {
            _passphrase = passphrase;
        }

        public string Encrypt(string text) => EncryptProvider.AESEncrypt(text, _passphrase);
        public string Decrypt(string encryptedText) => EncryptProvider.AESDecrypt(encryptedText, _passphrase);
    }
}
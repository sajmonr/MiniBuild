namespace MiniBuild.Security
{
    public interface IEncryption
    {
        string Encrypt(string text);
        string Decrypt(string encryptedText);
    }
}
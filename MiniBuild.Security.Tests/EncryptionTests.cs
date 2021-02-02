using Xunit;

namespace MiniBuild.Security.Tests
{
    public class EncryptionTests
    {
        private readonly IEncryption _sut;
        public EncryptionTests()
        {
            _sut = new Encryption("naDDRt0YctEdXYKPeF0nrf2vqyKaakBm");
        }

        [Fact]
        public void CanEncryptAndDecrypt()
        {
            var text = "adam";
            var encrypted = _sut.Encrypt(text);
            var decrypted = _sut.Decrypt(encrypted);

            Assert.Equal(text, decrypted);
        }

    }
}
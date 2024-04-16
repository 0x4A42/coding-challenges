using alphabet_cipher.src;

namespace alphabet_cipher_tests
{
    public class AlphabetCiperTests
    {
        readonly AlphabetCipher _sut = new();

        [Theory]
        [InlineData("meetmebythetree", "sconessconessco", "egsgqwtahuiljgs")]
        [InlineData("jordan", "yesyes", "hsjbef")]
        [InlineData("secret", "covert", "usxvvm")]
        public void EncryptString_Correct(string stringToEncrypt, string encryptionPhrase, string encryptedString)
        {
            Assert.Equal(encryptedString, _sut.EncryptString(stringToEncrypt, encryptionPhrase));
        }

        [Theory]
        [InlineData("meetmebythetree", "sconessconessco", "usxvvm")]
        [InlineData("jordan", "yesyes", "egsgqwtahuiljgs")]
        [InlineData("secret", "covert", "hsjbef")]
        public void EncryptString_Incorrect(string stringToEncrypt, string encryptionPhrase, string encryptedString)
        {
            Assert.NotEqual(encryptedString, _sut.EncryptString(stringToEncrypt, encryptionPhrase));
        }


        [Theory]
        [InlineData("egsgqwtahuiljgs", "sconessconessco", "meetmebythetree")]
        [InlineData("hsjbef", "yesyes", "jordan")]
        [InlineData("usxvvm", "covert", "secret")]
        public void DeryptString_Correct(string stringToEncrypt, string encryptionPhrase, string encryptedString)
        {
            Assert.Equal(encryptedString, _sut.DecryptString(stringToEncrypt, encryptionPhrase));
        }

        [Theory]
        [InlineData("egsgqwtahuiljgs", "sconessconessco", "secret")]
        [InlineData("hsjbef", "yesyes", "meetmebythetree")]
        [InlineData("usxvvm", "covert", "jordan")]
        public void DeryptString_Incorrect(string stringToEncrypt, string encryptionPhrase, string encryptedString)
        {
            Assert.NotEqual(encryptedString, _sut.DecryptString(stringToEncrypt, encryptionPhrase));
        }
    }
}
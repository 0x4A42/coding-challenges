using alphabet_cipher.src;

namespace alphabet_cipher_tests
{
    public class LetterSubstitutorTests
    {
        readonly LetterSubstitutor _sut = new();

        [Theory]
        [InlineData("meetmebythetree", "sconessconessco", "egsgqwtahuiljgs")]
        [InlineData("jordan", "yesyes", "hsjbef")]
        [InlineData("secret", "covert", "usxvvm")]
        public void EncryptStringCorrectly(string stringToEncrypt, string encryptionPhrase, string encryptedString)
        {
            Assert.Equal(encryptedString, _sut.EncryptString(stringToEncrypt, encryptionPhrase));
        }

        [Theory]
        [InlineData("meetmebythetree", "sconessconessco", "usxvvm")]
        [InlineData("jordan", "yesyes", "egsgqwtahuiljgs")]
        [InlineData("secret", "covert", "hsjbef")]
        public void IncorrectExpectedResult(string stringToEncrypt, string encryptionPhrase, string encryptedString)
        {
            Assert.NotEqual(encryptedString, _sut.EncryptString(stringToEncrypt, encryptionPhrase));
        }
    }
}
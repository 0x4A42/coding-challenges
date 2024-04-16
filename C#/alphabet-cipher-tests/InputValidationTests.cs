using AlphabetCipherChallenge;

namespace AlpabetCipherTests
{
    public class InputValidationTests
    {

        [Theory]
        [InlineData("meetmebythetree")]
        [InlineData("hello there")]
        [InlineData("YES")]
        public void ValidStringChecking(string stringToEncrypt)
        {
            Assert.True(InputValidation.IsValid(stringToEncrypt));
        }

        [Theory]
        [InlineData("")]
        [InlineData("123")]
        [InlineData("he110")]
        public void InvalidStringChecking(string stringToEncrypt)
        {
            Assert.False(InputValidation.IsValid(stringToEncrypt));
        }

        [Theory]
        [InlineData("eXiT")]
        [InlineData("quit")]
        [InlineData("STOP")]
        [InlineData("End")]
        public void UserWantsToExit_True(string userInput)
        {
            Assert.True(InputValidation.UserWantsToExit(userInput));
        }

        [Theory]
        [InlineData("HELLO")]
        [InlineData("encryptthisplease")]
        public void UserWantsToExit_False(string userInput)
        {
            Assert.False(InputValidation.UserWantsToExit(userInput));
        }


        [Theory]
        [InlineData("abc", 11, "abcabcabcab")]
        [InlineData("encryptthisplease", 20, "encryptthispleaseenc")]
        [InlineData("abcdef", 4, "abcd")]
        public void EncryptionStringLengthener(string input, int length, string expected)
        {
            Assert.Equal(expected, InputValidation.SecretPhraseLengthModifier(input, length));
        }

    }
}

using alphabet_cipher;
using alphabet_cipher.src;

string stringToEncrypt;
string userEnteredEncryptingPhrase;
string finalEncryptedPhrase;
bool continueLoop = true;
var substitutor = new LetterSubstitutor();


do
{
    Console.WriteLine("Please enter the phrase you wish to make secret.");
    stringToEncrypt = Console.ReadLine();

    if (InputValidation.UserWantsToExit(stringToEncrypt)) { break; }

    Console.WriteLine("Please enter the phrase you wish to use to encrypt the message with.");
    userEnteredEncryptingPhrase = Console.ReadLine();

    if (!InputValidation.IsValid(stringToEncrypt)) { continue; }
    if (!InputValidation.IsValid(userEnteredEncryptingPhrase)) { continue; }
   
    if (stringToEncrypt.Length != userEnteredEncryptingPhrase.Length) { finalEncryptedPhrase = InputValidation.EncryptionStringLengthener(userEnteredEncryptingPhrase, stringToEncrypt.Length); } else { finalEncryptedPhrase = userEnteredEncryptingPhrase;  }
    
    Console.WriteLine($"Your encrypted string is: '{substitutor.EncryptString(stringToEncrypt, finalEncryptedPhrase)}'.");
    
} while (continueLoop);

 
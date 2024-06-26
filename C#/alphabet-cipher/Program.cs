﻿using AlphabetCipherChallenge;

string stringToCipher;
string userSecretPhrase;
string finalSecretPhrase;
string operation;
string response;
var substitutor = new AlphabetCipher();

do
{
    do
    {
        Console.WriteLine("Would you like to Encrypt or Decrypt a message?");
        operation = Console.ReadLine();
    } while (!operation.ToUpper().Equals("ENCRYPT") && !operation.ToUpper().Equals("DECRYPT"));

    Console.WriteLine($"Please enter the phrase you wish to {operation.ToLower()}.");
    stringToCipher = Console.ReadLine();

    if (InputValidation.UserWantsToExit(stringToCipher)) { break; }

    if (!InputValidation.IsValid(stringToCipher)) { continue; }

    Console.WriteLine($"Please enter the phrase that will be used to {operation.ToLower()}.");
    userSecretPhrase = Console.ReadLine();

    if (!InputValidation.IsValid(userSecretPhrase)) { continue; }

    if (stringToCipher.Length != userSecretPhrase.Length)
    {
        finalSecretPhrase = InputValidation.SecretPhraseLengthModifier(userSecretPhrase, stringToCipher.Length);
    }
    else
    {
        finalSecretPhrase = userSecretPhrase;
    }

    if (operation.ToUpper().Equals("ENCRYPT"))
    {
        Console.WriteLine($"Your encrypted string is: '{substitutor.EncryptString(stringToCipher, finalSecretPhrase)}'.");
    } else
    {
        Console.WriteLine($"Your decrypted string is: '{substitutor.DecryptString(stringToCipher, finalSecretPhrase)}'.");
    }

    do
    {
        Console.WriteLine("Would you like to encrypt or decrypt another phrase? (Y/N)");
        response = Console.ReadLine();
    } while (!response.ToUpper().Equals("Y") && !response.ToUpper().Equals("N"));

    if(response.ToUpper().Equals("N")){ break; }

} while(true);


﻿
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace alphabet_cipher
{
    internal static class InputValidation
    {
        readonly static string[] exitConditions = ["EXIT", "STOP", "QUIT", "END"];
        public static bool IsValid(string input) {

            if (String.IsNullOrWhiteSpace(input)) { Console.Error.WriteLine("Could not encrypt your phrase - cannot be empty."); return false; }
            if (input.Any(char.IsDigit)) { Console.Error.WriteLine($"Could not encrypt {input} - your phrase cannot contain numbers."); return false; }
            return true;
        }

        public static bool UserWantsToExit(string input) {

            if (exitConditions.Contains(input.ToUpper())) { return true; }
            return false;
        }

        public static string EncryptionStringLengthener(string input, int length)
        {
            var builder = new StringBuilder(length);
            do
            {
                foreach (char c in input)
                {
                    builder.Append(c);
                    if (builder.Length == length) { break; }
                }
            } while (builder.Length < length);

            return builder.ToString();
        }
    }
}

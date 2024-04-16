namespace alphabet_cipher.src
{
    public class LetterSubstitutor
    {

        private readonly Dictionary<char, string> alphabetSubstitutionChart;
        private readonly Dictionary<char, int> characterPlaceInAlphabet;

        public LetterSubstitutor()
        {
            alphabetSubstitutionChart = InitialiseSubstitutionChart(new Dictionary<char, string>());
            characterPlaceInAlphabet = InitialiseAlphabetLookUpDictionary(new Dictionary<char, int>());
        }

        private Dictionary<char, string> InitialiseSubstitutionChart(Dictionary<char, string> substitutionChart)
        {
            return new Dictionary<char, string>() {
            {'A', "abcdefghijklmnopqrstuvwxyz"},
            {'B', "bcdefghijklmnopqrstuvwxyza"},
            {'C', "cdefghijklmnopqrstuvwxyzab"},
            {'D', "defghijklmnopqrstuvwxyzabc"},
            {'E', "efghijklmnopqrstuvwxyzabcd"},
            {'F', "fghijklmnopqrstuvwxyzabcde"},
            {'G', "ghijklmnopqrstuvwxyzabcdef"},
            {'H', "hijklmnopqrstuvwxyzabcdefg"},
            {'I', "ijklmnopqrstuvwxyzabcdefgh"},
            {'J', "jklmnopqrstuvwxyzabcdefghi"},
            {'K', "klmnopqrstuvwxyzabcdefghij"},
            {'L', "lmnopqrstuvwxyzabcdefghijk"},
            {'M', "mnopqrstuvwxyzabcdefghijkl"},
            {'N', "nopqrstuvwxyzabcdefghijklm"},
            {'O', "opqrstuvwxyzabcdefghijklmn"},
            {'P', "pqrstuvwxyzabcdefghijklmno"},
            {'Q', "qrstuvwxyzabcdefghijklmnop"},
            {'R', "rstuvwxyzabcdefghijklmnopq"},
            {'S', "stuvwxyzabcdefghijklmnopqr"},
            {'T', "tuvwxyzabcdefghijklmnopqrs"},
            {'U', "uvwxyzabcdefghijklmnopqrst"},
            {'V', "vwxyzabcdefghijklmnopqrstu"},
            {'W', "wxyzabcdefghijklmnopqrstuv"},
            {'X', "xyzabcdefghijklmnopqrstuvw"},
            {'Y', "yzabcdefghijklmnopqrstuvwx"},
            {'Z', "zabcdefghijklmnopqrstuvwxy"}
        };
        }

        private Dictionary<char, int> InitialiseAlphabetLookUpDictionary(Dictionary<char, int> characterPlaceInAlphabet)
        {
            return new Dictionary<char, int>() {
            {'A', 0},
            {'B', 1},
            {'C', 2},
            {'D', 3},
            {'E', 4},
            {'F', 5},
            {'G', 6},
            {'H', 7},
            {'I', 8},
            {'J', 9},
            {'K', 10},
            {'L', 11},
            {'M', 12},
            {'N', 13},
            {'O', 14},
            {'P', 15},
            {'Q', 16},
            {'R', 17},
            {'S', 18},
            {'T', 19},
            {'U', 20},
            {'V', 21},
            {'W', 22},
            {'X', 23},
            {'Y', 24},
            {'Z', 25}
        };
        }


        public string EncryptString(string stringToEncrypt, string encryptingPhrase)
        {
            var encryptedString = "";
            for (int i = 0; i < stringToEncrypt.Length; i++)
            {
                encryptedString += EncryptLetter(stringToEncrypt[i], encryptingPhrase[i]);
            }
            return encryptedString;
        }

        private char EncryptLetter(char letterToConvert, char substitutionChartKeyChar)
        {
            var substitutionRow = alphabetSubstitutionChart[char.ToUpper(substitutionChartKeyChar)];
            var placeInAlphabet = characterPlaceInAlphabet[char.ToUpper(letterToConvert)];
            return substitutionRow[placeInAlphabet];
        }
    }

}

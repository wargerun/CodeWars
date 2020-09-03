using System.Linq;

namespace CodeWars.Test.Task14
{
    internal static class Kata
    {
        private const int ROT_13_SHIFT = 13;

        /// <summary>
        /// How can you tell an extrovert from an introvert at NSA? Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.
        /// I found this joke on USENET, but the punchline is scrambled.Maybe you can decipher it? According to Wikipedia, ROT13 (http://en.wikipedia.org/wiki/ROT13) is frequently used to obfuscate jokes on USENET.
        /// Hint: For this task you're only supposed to substitue characters. Not spaces, punctuation, numbers etc. Test examples:
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        internal static string Rot13Decrypt(string input) => new string(input.Select(rot13Shift).ToArray());

        private static char rot13Shift(char letter)
        {
            const int LOWER_MIN = 97;
            const int LOWER_MAX = 122;

            const int UPPER_MIN = 65;
            const int UPPER_MAX = 90;

            if (!char.IsLetter(letter))
            {
                return letter;
            }

            return char.IsUpper(letter)
                ? shufleLetter(letter, UPPER_MIN, UPPER_MAX)
                : shufleLetter(letter, LOWER_MIN, LOWER_MAX);
        }

        private static char shufleLetter(char letter, int min, int max)
        {
            int letterOfNumber = (int)letter;

            for (int i = 0; i < ROT_13_SHIFT; i++)
            {
                if (letterOfNumber >= max)
                {
                    letterOfNumber = min;
                }
                else
                {
                    letterOfNumber++;
                }
            }

            return (char)letterOfNumber;
        }
    }
}
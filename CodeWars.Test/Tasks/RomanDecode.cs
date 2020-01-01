using System.Collections.Generic;

namespace CodeWars.Test.Tasks
{
    /// <summary>
    /// Roman Numerals Decoder  
    /// </summary>
    internal class RomanDecode
    {
        /*
             Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer.
             You don't need to validate the form of the Roman numeral.
             
            Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately,
            starting with the leftmost digit and skipping any 0s. So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC)
            and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). The Roman numeral for 1666, "MDCLXVI",
            uses each letter in descending order.

            Example:
            
            RomanDecode.Solution("XXI") -- should return 21

            Help:

Symbol    Value
I          1
V          5
X          10
L          50
C          100
D          500
M          1,000

             */     

        private static Dictionary<char, int> romanTable = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        internal static int Solution(string roman)
        {
            int summary = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                int current = romanTable[roman[i]];

                if (i >= roman.Length - 1)
                {
                    summary += current;
                }
                else
                {
                    int next = romanTable[roman[i + 1]];

                    summary = current < next ? summary -= current : summary += current;
                }                   
            }

            return summary;
        }
    }
}

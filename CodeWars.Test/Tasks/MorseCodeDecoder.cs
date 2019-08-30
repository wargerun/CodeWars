using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars.Test.Tasks
{
    public static class MorseCodeDecoder
    {
        private static Dictionary<string, string> GetDictionaryMorse()
        {
            const char dot = '.';
            const char dash = '-';

            return new Dictionary<string, string>
            {
                [string.Concat(dot, dash)] = "a",
                [string.Concat(dot, dash)] = "a",
                [string.Concat(dash, dot, dot, dot)] = "b",
                [string.Concat(dash, dot, dash, dot)] = "c",
                [string.Concat(dash, dot, dot)] = "d",
                [dot.ToString()] = "e",
                [string.Concat(dot, dot, dash, dot)] = "f",
                [string.Concat(dash, dash, dot)] = "g",
                [string.Concat(dot, dot, dot, dot)] = "h",
                [string.Concat(dot, dot)] = "i",
                [string.Concat(dot, dash, dash, dash)] = "j",
                [string.Concat(dash, dot, dash)] = "k",
                [string.Concat(dot, dash, dot, dot)] = "l",
                [string.Concat(dash, dash)] = "m",
                [string.Concat(dash, dot)] = "n",
                [string.Concat(dash, dash, dash)] = "o",
                [string.Concat(dot, dash, dash, dot)] = "p",
                [string.Concat(dash, dash, dot, dash)] = "q",
                [string.Concat(dot, dash, dot)] = "r",
                [string.Concat(dot, dot, dot)] = "s",
                [string.Concat(dash)] = "t",
                [string.Concat(dot, dot, dash)] = "u",
                [string.Concat(dot, dot, dot, dash)] = "v",
                [string.Concat(dot, dash, dash)] = "w",
                [string.Concat(dash, dot, dot, dash)] = "x",
                [string.Concat(dash, dot, dash, dash)] = "y",
                [string.Concat(dash, dash, dot, dot)] = "z",
                [string.Concat(dash, dash, dash, dash, dash)] = "0",
                [string.Concat(dot, dash, dash, dash, dash)] = "1",
                [string.Concat(dot, dot, dash, dash, dash)] = "2",
                [string.Concat(dot, dot, dot, dash, dash)] = "3",
                [string.Concat(dot, dot, dot, dot, dash)] = "4",
                [string.Concat(dot, dot, dot, dot, dot)] = "5",
                [string.Concat(dash, dot, dot, dot, dot)] = "6",
                [string.Concat(dash, dash, dot, dot, dot)] = "7",
                [string.Concat(dash, dash, dash, dot, dot)] = "8",
                [string.Concat(dash, dash, dash, dash, dot)] = "9",
                [string.Concat(dot, dot, dot, dash, dash, dash, dot, dot, dot)] = "sos",
                [string.Concat(dash, dot, dash, dot, dash, dash)] = "!",
                [string.Concat(dot, dash, dot, dash, dot, dash)] = "."
            };
        }

        public static string Decode(string input)
        {
            List<string> words = input.Split("   ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, string> dctMorse = GetDictionaryMorse();
            List<string> decode = new List<string>();
            foreach (string word in words)
            {
                List<string> symbols = word.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                StringBuilder sb = new StringBuilder();

                foreach (string symbol in symbols)
                {
                    if (dctMorse.TryGetValue(symbol, out string value))
                    {
                        sb.Append(value);
                    }
                    else
                        throw new Exception(symbol);
                }

                decode.Add(sb.ToString());
            }

            return string.Join(" ", decode).ToUpper();
        }
    }
}
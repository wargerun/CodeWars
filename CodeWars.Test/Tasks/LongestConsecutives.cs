using System.Linq;
using System.Xml.Xsl;

namespace CodeWars.Test.Tasks
{
    /// <summary>
    /// You are given an array strarr of strings and an integer k.Your task is to return the first longest string consisting of k consecutive strings taken in the array.
    /// Example:
    /// longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"
    /// n being the length of the string array, if n = 0 or k > n or k  V= zero return ""
    /// Note
    /// consecutive strings : follow one after another without an interruption
    /// </summary>
    public static class LongestConsecutives
    {
        public static string LongestConsec(string[] strarr, int k)
        {
            if (k > strarr.Length || strarr.Length == 0 || k <= 0)
            {
                return string.Empty;
            }

            string currentStr = string.Empty;
            for (int i = 0; i < strarr.Length; i++)
            {
                string str = string.Empty;
                for (int j = i; j < k + i && j < strarr.Length; j++)
                {
                    str += strarr[j];
                }

                if (currentStr.Length < str.Length)
                {
                    currentStr = str;
                }
            }

            return currentStr;
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Test.Task11
{
    public class SplitString
    {
        public static string[] Solution(string str)
        {
            if (str.Length % 2 != 0)
            {
                str += "_";
            }

            List<string> splitStrings = new List<string>();
            int offset = 0;
            do
            {
                splitStrings.Add(new string(str.Skip(offset).Take(2).ToArray()));
                offset += 2;
            } while (offset < str.Length);


            return splitStrings.ToArray();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace CodeWars.Test.Tasks
{
    public static class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            // my code                          
            List<string> res = (s1 + s2).Distinct().Select(d => d.ToString()).ToList();
            res.Sort();                                                                
            return string.Join("", res);
        }
    }
}
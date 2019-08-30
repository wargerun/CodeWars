using System;
using System.Linq;

namespace CodeWars.Test.Tasks
{
    public static class CheckXo
    {
        private const string X = "x";
        private const string O = "o";

        internal static bool Xo(string someText)
        {
            int countX = someText.ToLower().Count(i => i == 'x');
            int countO = someText.ToLower().Count(i => i == 'o');

            return countX == countO;
        }   
    }
}
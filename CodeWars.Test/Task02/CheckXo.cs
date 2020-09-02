using System.Linq;

namespace CodeWars.Test.Task02
{
    public static class CheckXo
    {
        internal static bool Xo(string someText)
        {
            int countX = someText.ToLower().Count(i => i == 'x');
            int countO = someText.ToLower().Count(i => i == 'o');

            return countX == countO;
        }
    }
}

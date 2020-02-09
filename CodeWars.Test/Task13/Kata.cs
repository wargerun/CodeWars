using System.Collections.Generic;

namespace CodeWars.Test.Task13
{
    public class Kata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            T current = default;
            foreach (T x1 in iterable)
            {
                if (!x1.Equals(current))
                {
                    current = x1;
                    yield return x1;
                }
            }
        }
    }
}
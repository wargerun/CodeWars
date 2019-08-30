using System.Linq;

namespace CodeWars.Test.Tasks
{
    public static class Persist
    {
        public static int Persistence(long numbers)
        {
            long[] arrayNumbers = SplitNumbers(numbers);

            int countIteration = 0;
            while (arrayNumbers.Length != 1)
            {
                long multiplyValue = Multiply(arrayNumbers);
                arrayNumbers = SplitNumbers(multiplyValue);

                countIteration++;
            }

            return countIteration;
        }

        private static long[] SplitNumbers(long multiplyValue) => multiplyValue.ToString().Select(d => long.Parse(d.ToString())).ToArray();

        private static long Multiply(params long[] numbers) => numbers.Aggregate((current, number) => current * number);
    }
}
using NUnit.Framework;
using System;

namespace CodeWars.Test.Task06
{
    [TestFixture]
    public class SumDigPowerTests
    {
        [Test]
        public void Task_6_Test()
        {
            Console.WriteLine("Basic Tests SumDigPow");
            Testing(1, 10, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Testing(1, 100, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 89 });
            Testing(10, 100, new long[] { 89 });
            Testing(90, 100, new long[] { });
            Testing(90, 150, new long[] { 135 });
            Testing(50, 150, new long[] { 89, 135 });
            Testing(10, 150, new long[] { 89, 135 });

            void Testing(long a, long b, long[] res) => Assert.AreEqual(Array2String(res), Array2String(SumDigPower.SumDigPow(a, b)));

            string Array2String(long[] list) => "[" + string.Join(", ", list) + "]";
        }
    }
}

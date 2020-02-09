using NUnit.Framework;

namespace CodeWars.Test.Task13
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", Kata.UniqueInOrder(""));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", Kata.UniqueInOrder("AAAABBBCCDAABBB"));
        }
    }
}
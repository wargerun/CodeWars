using NUnit.Framework;

namespace CodeWars.Test.Task11
{            
    [TestFixture]
    internal class SplitStringTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, SplitString.Solution("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitString.Solution("abcdef"));
        }
    }
}

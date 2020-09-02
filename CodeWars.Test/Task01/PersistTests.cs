using NUnit.Framework;

namespace CodeWars.Test.Task01
{
    [TestFixture]
    public class CheckXoTests
    {
        [Test]
        public void Task_1_Test()
        {
            Assert.AreEqual(3, Persist.Persistence(39));
            Assert.AreEqual(0, Persist.Persistence(4));
            Assert.AreEqual(2, Persist.Persistence(25));
            Assert.AreEqual(4, Persist.Persistence(999));
        }
    }
}

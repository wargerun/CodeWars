using NUnit.Framework;

namespace CodeWars.Test.Task02
{
    [TestFixture]
    public class CheckXoTests
    {
        [Test]
        public void Task_2_Test()
        {
            Assert.AreEqual(true, CheckXo.Xo("xxOo"));
            Assert.AreEqual(true, CheckXo.Xo("xo"));
            Assert.AreEqual(false, CheckXo.Xo("xxxm"));
            Assert.AreEqual(false, CheckXo.Xo("Oo"));
            Assert.AreEqual(false, CheckXo.Xo("ooom"));
        }
    }
}

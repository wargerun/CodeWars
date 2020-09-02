using NUnit.Framework;
using System.Text;

namespace CodeWars.Test.Task10
{
    [TestFixture]
    public class DiamondTests
    {
        [Test]
        public void TestNull()
        {
            Assert.IsNull(Diamond.print(0));
            Assert.IsNull(Diamond.print(-2));
            Assert.IsNull(Diamond.print(2));
        }

        [Test]
        public void TestDiamond1()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("*\n");
            Assert.AreEqual(expected.ToString(), Diamond.print(1));
        }

        [Test]
        public void TestDiamond3()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append(" *\n");
            expected.Append("***\n");
            expected.Append(" *\n");

            Assert.AreEqual(expected.ToString(), Diamond.print(3));
        }

        [Test]
        public void TestDiamond5()
        {
            StringBuilder expected = new StringBuilder();
            expected.Append("  *\n");
            expected.Append(" ***\n");
            expected.Append("*****\n");
            expected.Append(" ***\n");
            expected.Append("  *\n");

            Assert.AreEqual(expected.ToString(), Diamond.print(5));
        }
    }
}

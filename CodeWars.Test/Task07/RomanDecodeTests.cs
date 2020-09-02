using NUnit.Framework;

namespace CodeWars.Test.Task07
{
    [TestFixture]
    public class RomanDecodeTests
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(16, "XVI")]
        [TestCase(17, "XVII")]
        [TestCase(18, "XVIII")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        [TestCase(21, "XXI")]
        [TestCase(22, "XXII")]
        [TestCase(23, "XXIII")]
        [TestCase(24, "XXIV")]
        [TestCase(25, "XXV")]
        [TestCase(26, "XXVI")]
        [TestCase(27, "XXVII")]
        [TestCase(28, "XXVIII")]
        [TestCase(29, "XXIX")]
        [TestCase(30, "XXX")]
        public void Task_7_Tests(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanDecode.Solution(roman));
        }
    }
}

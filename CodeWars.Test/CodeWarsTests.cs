using System;
using NUnit.Framework;
using System.Linq;
using CodeWars.Test.Tasks;

namespace CodeWars.Test
{
    [TestFixture]
    public class CodeWarsTests
    {
        [Test]
        public void Task_1_Test()
        {
            Assert.AreEqual(3, Persist.Persistence(39));
            Assert.AreEqual(0, Persist.Persistence(4));
            Assert.AreEqual(2, Persist.Persistence(25));
            Assert.AreEqual(4, Persist.Persistence(999));
        }

        [Test]
        public void Task_2_Test()
        {
            Assert.AreEqual(true, CheckXo.Xo("xxOo"));
            Assert.AreEqual(true, CheckXo.Xo("xo"));
            Assert.AreEqual(false, CheckXo.Xo("xxxm"));
            Assert.AreEqual(false, CheckXo.Xo("Oo"));
            Assert.AreEqual(false, CheckXo.Xo("ooom"));
        }

        [Test]
        public void Task_3_Test()
        {
            try
            {
                string input = ".... . -.--   .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void Task_4_Test()
        {
            Assert.AreEqual("aehrsty", TwoToOne.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", TwoToOne.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", TwoToOne.Longest("inmanylanguages", "theresapairoffunctions"));
        }

        [Test]
        public void Task_5_Test()
        {
            Console.WriteLine("Basic Tests");
            Testing(LongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2), "abigailtheta");
            Testing(LongestConsecutives.LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1), "oocccffuucccjjjkkkjyyyeehh");
            Testing(LongestConsecutives.LongestConsec(new String[] { }, 3), "");
            Testing(LongestConsecutives.LongestConsec(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2), "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
            Testing(LongestConsecutives.LongestConsec(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2), "wlwsasphmxxowiaxujylentrklctozmymu");
            Testing(LongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2), "");
            Testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3), "ixoyx3452zzzzzzzzzzzz");
            Testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15), "");
            Testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0), "");

            void Testing(string actual, string expected) => Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void Task_6_Test()
        {
            Console.WriteLine("Basic Tests SumDigPow");
            Testing(1, 10, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Testing(1, 100, new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 89 });
            Testing(10, 100, new long[] { 89 });
            Testing(90, 100, new long[] { });
            Testing(90, 150, new long[] { 135 });
            Testing(50, 150, new long[] { 89, 135 });
            Testing(10, 150, new long[] { 89, 135 });

            void Testing(long a, long b, long[] res) => Assert.AreEqual(Array2String(res),Array2String(SumDigPower.SumDigPow(a, b)));

            string Array2String(long[] list) => "[" + string.Join(", ", list) + "]";
        }

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

        [Test]
        public void Task_8_Tests()
        {
            Assert.AreEqual(true, IPValidation.is_valid_IP("0.0.0.0"));
            Assert.AreEqual(true, IPValidation.is_valid_IP("12.255.56.1"));
            Assert.AreEqual(true, IPValidation.is_valid_IP("137.255.156.100"));

            Assert.AreEqual(false, IPValidation.is_valid_IP(""));
            Assert.AreEqual(false, IPValidation.is_valid_IP("abc.def.ghi.jkl"));
            Assert.AreEqual(false, IPValidation.is_valid_IP("123.456.789.0"));
            Assert.AreEqual(false, IPValidation.is_valid_IP("12.34.56"));
            Assert.AreEqual(false, IPValidation.is_valid_IP("12.34.56.00"));
            Assert.AreEqual(false, IPValidation.is_valid_IP("12.34.56.7.8"));
            Assert.AreEqual(false, IPValidation.is_valid_IP("12.34.256.78"));
            Assert.AreEqual(false, IPValidation.is_valid_IP("1234.34.56"));
            Assert.AreEqual(false, IPValidation.is_valid_IP("pr12.34.56.78"));
            Assert.AreEqual(false, IPValidation.is_valid_IP("12.34.56.78sf"));
            Assert.AreEqual(false, IPValidation.is_valid_IP("12.34.56 .1"));
            Assert.AreEqual(false, IPValidation.is_valid_IP("12.34.56.-1"));
            Assert.AreEqual(false, IPValidation.is_valid_IP("123.045.067.089"));
        }

        [Test, Description("It should return correct text")]
        public void Task_9_Tests()
        {
            Assert.AreEqual("no one likes this", PeopleLikes.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", PeopleLikes.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", PeopleLikes.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", PeopleLikes.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", PeopleLikes.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
}
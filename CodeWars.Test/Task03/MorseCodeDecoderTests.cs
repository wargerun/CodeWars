using NUnit.Framework;
using System;

namespace CodeWars.Test.Task03
{
    [TestFixture]
    public class MorseCodeDecoderTests
    {
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
    }
}

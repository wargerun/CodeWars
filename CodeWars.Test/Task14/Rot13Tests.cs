using NUnit.Framework;

namespace CodeWars.Test.Task14
{
    [TestFixture]
    public class Rot13Tests
    {
        /// <summary>
        /// https://www.codewars.com/kata/52223df9e8f98c7aa7000062/train/csharp
        /// </summary>
        [TestCase("EBG13 rknzcyr.", ExpectedResult = "ROT13 example.")]
        [TestCase("Guvf vf zl svefg EBG13 rkprepvfr!", ExpectedResult = "This is my first ROT13 excercise!")]
        [TestCase("SERR CVMMN!", ExpectedResult = "FREE PIZZA!")]
        public string Rot13Test(string text)
        {
            return Kata.Rot13Decrypt(text);
        }
    }
}

using NUnit.Framework;

namespace CodeWars.Test.Task09
{
    [TestFixture]
    public class PeopleLikesTests
    {
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

using NUnit.Framework;

using System.Collections.Generic;

namespace CodeWars.Test.Task15
{
    // TODO: Replace examples and use TDD development by writing your own tests
    [TestFixture]
    public class SolutionTest
    {
        private readonly IList<int> collection = new List<int> {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24 };
        private PagnationHelper<int> helper;

        [SetUp]
        public void SetUp()
        {
            helper = new PagnationHelper<int>(collection, 10);
        }

        [Test]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(1, ExpectedResult = 10)]
        [TestCase(3, ExpectedResult = -1)]
        public int PageItemCountTest(int pageIndex)
        {
            return helper.PageItemCount(pageIndex);
        }

        [Test]
        [TestCase(-1, ExpectedResult = -1)]
        [TestCase(12, ExpectedResult = 1)]
        [TestCase(24, ExpectedResult = -1)]
        public int PageIndexTest(int itemIndex)
        {
            return helper.PageIndex(itemIndex);
        }

        [Test]
        public void ItemCountTest()
        {
            Assert.AreEqual(24, helper.ItemCount);
        }

        [Test]
        public void PageCountTest()
        {
            Assert.AreEqual(3, helper.PageCount);
        }

        [Test]
        public void PageIndexTest()
        {
            var helper = new PagnationHelper<char>(new List<char> { 
                'a', 'b', 'c', 'd',
                'e', 'f' }, 4);

            Assert.AreEqual(2, helper.PageCount); 
            Assert.AreEqual(6, helper.ItemCount);
            
            Assert.AreEqual(4, helper.PageItemCount(0)); //should == 4
            Assert.AreEqual(2, helper.PageItemCount(1)); // last page - should == 2
            Assert.AreEqual(-1, helper.PageItemCount(2)); // should == -1 since the page is invalid

            // pageIndex takes an item index and returns the page that it belongs on
            Assert.AreEqual(1, helper.PageIndex(5)); //should == 1 (zero based index)
            Assert.AreEqual(0, helper.PageIndex(2)); //should == 0
            Assert.AreEqual(-1, helper.PageIndex(20));
            Assert.AreEqual(-1, helper.PageIndex(-10)); //should == -1}
        }
    }
}

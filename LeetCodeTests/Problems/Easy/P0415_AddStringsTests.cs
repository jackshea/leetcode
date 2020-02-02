using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0415_AddStringsTests
    {
        [Test()]
        public void AddStringsTest()
        {
            Assert.AreEqual("58023", new P0415_AddStrings().AddStrings("1234", "56789"));
        }

        [Test()]
        public void AddStringsTest_1()
        {
            Assert.AreEqual("108", new P0415_AddStrings().AddStrings("9", "99"));
        }
    }
}
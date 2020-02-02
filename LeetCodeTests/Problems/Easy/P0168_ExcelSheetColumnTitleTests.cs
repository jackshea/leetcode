using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0168_ExcelSheetColumnTitleTests
    {
        [Test()]
        public void ConvertToTitleTest()
        {
            var test = new P0168_ExcelSheetColumnTitle();
            Assert.AreEqual("A", test.ConvertToTitle(1));
            Assert.AreEqual("AB", test.ConvertToTitle(28));
            Assert.AreEqual("AZ", test.ConvertToTitle(52));
            Assert.AreEqual("ZY", test.ConvertToTitle(701));
            Assert.AreEqual("AAA", test.ConvertToTitle(703));
        }
    }
}
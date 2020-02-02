using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0994_RottingOrangesTests
    {
        [Test()]
        public void OrangesRottingTest()
        {
            var input = new int[][] { new[] { 2, 1, 1 }, new[] { 1, 1, 0 }, new[] { 0, 1, 1 } };
            var test = new P0994_RottingOranges();
            Assert.AreEqual(4, test.OrangesRotting(input));
        }

        [Test()]
        public void OrangesRottingTest_1()
        {
            var input = new int[][] { new[] { 1, 2 }, new[] { 2, 1 } };
            var test = new P0994_RottingOranges();
            Assert.AreEqual(1, test.OrangesRotting(input));
        }
    }
}
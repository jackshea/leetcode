using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0697_DegreeOfAnArrayTests
    {
        [Test()]
        public void FindShortestSubArrayTest()
        {
            var test = new P0697_DegreeOfAnArray();
            var result = test.FindShortestSubArray(new[] { 1, 2, 2, 3, 1, 4, 2 });
            Assert.AreEqual(6, result);
        }
    }
}
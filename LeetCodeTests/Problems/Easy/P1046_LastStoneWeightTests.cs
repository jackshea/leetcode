using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P1046_LastStoneWeightTests
    {
        [Test()]
        public void LastStoneWeightTest()
        {
            var test = new P1046_LastStoneWeight();
            Assert.AreEqual(1, test.LastStoneWeight(new[] { 2, 7, 4, 1, 8, 1 }));
        }

        [Test()]
        public void LastStoneWeightTest_1()
        {
            var test = new P1046_LastStoneWeight();
            Assert.AreEqual(2, test.LastStoneWeight(new[] { 3, 7, 8 }));
        }
    }
}
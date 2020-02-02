using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0204_CountPrimesTests
    {
        [Test()]
        public void CountPrimesTest()
        {
            int input = 10;
            var countPrimes = new P0204_CountPrimes().CountPrimes(input);
            Assert.AreEqual(4, countPrimes);
        }

        [Test()]
        public void CountPrimesTest1()
        {
            int input = 2;
            var countPrimes = new P0204_CountPrimes().CountPrimes(input);
            Assert.AreEqual(0, countPrimes);
        }
    }
}
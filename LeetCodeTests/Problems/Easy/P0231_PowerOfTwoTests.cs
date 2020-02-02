using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0231_PowerOfTwoTests
    {
        [Test()]
        public void IsPowerOfTwoTest()
        {
            var input = -16;
            var isPowerOfTwo = new P0231_PowerOfTwo().IsPowerOfTwo(input);
            Assert.IsFalse(isPowerOfTwo);
        }

        [Test()]
        public void IsPowerOfTwoTest_1()
        {
            var input = -24;
            var isPowerOfTwo = new P0231_PowerOfTwo().IsPowerOfTwo(input);
            Assert.IsFalse(isPowerOfTwo);
        }
    }
}
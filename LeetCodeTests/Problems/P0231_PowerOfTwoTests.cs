using NUnit.Framework;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Tests
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
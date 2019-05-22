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
    public class P191_NumberOf1BitsTests
    {
        [Test()]
        public void HammingWeightTest()
        {
            uint input = 0b00000000000000000000000000001011;
            var hammingWeight = new P191_NumberOf1Bits().HammingWeight(input);
            Assert.AreEqual(3, hammingWeight);
        }

        [Test()]
        public void HammingWeightTest_1()
        {
            uint input = 0b00000000000000000000000010000000;
            var hammingWeight = new P191_NumberOf1Bits().HammingWeight(input);
            Assert.AreEqual(1, hammingWeight);
        }

        [Test()]
        public void HammingWeightTest_2()
        {
            uint input = 0b11111111111111111111111111111101;
            var hammingWeight = new P191_NumberOf1Bits().HammingWeight(input);
            Assert.AreEqual(31, hammingWeight);
        }
    }
}
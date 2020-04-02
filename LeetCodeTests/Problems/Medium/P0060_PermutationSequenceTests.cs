using NUnit.Framework;
using LeetCode.Problems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Medium.Tests
{
    [TestFixture()]
    public class P0060_PermutationSequenceTests
    {
        [Test()]
        public void GetPermutationTest()
        {
            var test = new P0060_PermutationSequence();
            var permutation = test.GetPermutation(4, 9);
            Assert.AreEqual("2314", permutation);
        }

        [Test()]
        public void GetPermutationTest1()
        {
            var test = new P0060_PermutationSequence();
            var permutation = test.GetPermutation(2, 2);
            Assert.AreEqual("21", permutation);
        }
    }
}
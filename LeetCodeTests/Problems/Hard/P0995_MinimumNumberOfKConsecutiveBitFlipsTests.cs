using NUnit.Framework;
using LeetCode.Problems.Hard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Hard.Tests
{
    [TestFixture()]
    public class P0995_MinimumNumberOfKConsecutiveBitFlipsTests
    {
        [Test()]
        public void MinKBitFlipsTest()
        {
            var test = new P0995_MinimumNumberOfKConsecutiveBitFlips();
            Assert.AreEqual(3, test.MinKBitFlips(new[] { 0, 1, 0, 0, 1, 0 }, 4));
        }
    }
}
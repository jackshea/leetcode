using NUnit.Framework;
using LeetCode.Problems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Problems.Easy;

namespace LeetCode.Problems.Medium.Tests
{
    [TestFixture()]
    public class P0264_UglyNumberIITests
    {
        [Test()]
        public void NthUglyNumberTest()
        {
            var test = new P0264_UglyNumberII();
            var actual = test.NthUglyNumber(10);
            Assert.AreEqual(12, actual);
        }
    }
}
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
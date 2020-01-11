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
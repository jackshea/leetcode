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
    public class MST40_LCOF_1Tests
    {
        [Test()]
        public void GetLeastNumbersTest()
        {
            var test = new MST40_LCOF_1();
            var res = test.GetLeastNumbers(new[] { 3, 2, 1 }, 2);
            Assert.AreEqual(new[] { 1, 2 }, res);
        }

        [Test()]
        public void GetLeastNumbersTest_1()
        {
            var test = new MST40_LCOF_1();
            var res = test.GetLeastNumbers(new[] { 0, 0, 1, 2, 4, 2, 2, 3, 1, 4 }, 8);
            Assert.AreEqual(new[] { 3, 2, 2, 2, 1, 1, 0, 0 }, res);
        }
    }
}
using NUnit.Framework;
using LeetCode.Problems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode.Problems.Medium.Tests
{
    [TestFixture()]
    public class P0743_NetworkDelayTimeTests
    {
        [Test()]
        public void NetworkDelayTimeTest()
        {
            var test = new P0743_NetworkDelayTime();
            int[][] times = Utils.Read2DArray("[[2, 1, 1],[2, 3, 1],[3, 4, 1]]");
            var actual = test.NetworkDelayTime(times, 4, 2);
            Assert.AreEqual(2, actual);
        }
    }
}
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
    public class P0797_AllPathsFromSourceToTargetTests
    {
        [Test()]
        public void AllPathsSourceTargetTest()
        {
            var test = new P0797_AllPathsFromSourceToTarget();
            int[][] g = Utils.Read2DArray(" [[1,2],[3],[3],[]]");
            int[][] expect = Utils.Read2DArray("[[0,1,3],[0,2,3]]");
            var ans = test.AllPathsSourceTarget(g);
            CollectionAssert.AreEquivalent(expect, ans);
        }
    }
}
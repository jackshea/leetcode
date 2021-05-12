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
    public class P1310_XorQueriesOfASubarrayTests
    {
        [Test()]
        public void XorQueriesTest()
        {
            var test = new P1310_XorQueriesOfASubarray();
            var arr = new int[] { 1, 3, 4, 8 };
            var queries = Utils.Read2DArray("[[0,1],[1,2],[0,3],[3,3]]");
            var ans = new int[] { 2, 7, 14, 8 };
            CollectionAssert.AreEqual(ans, test.XorQueries(arr, queries));
        }
    }
}
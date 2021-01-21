using NUnit.Framework;
using LeetCode.Problems.Hard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode.Problems.Hard.Tests
{
    [TestFixture()]
    public class P1489_FindCriticalAndPseudoCriticalEdgesInMinimumSpanningTreeTests
    {
        [Test()]
        public void FindCriticalAndPseudoCriticalEdgesTest()
        {
            var test = new P1489_FindCriticalAndPseudoCriticalEdgesInMinimumSpanningTree();
            var output = test.FindCriticalAndPseudoCriticalEdges(5,
                Utils.Read2DArray("[[0,1,1],[1,2,1],[2,3,2],[0,3,2],[0,4,3],[3,4,3],[1,4,6]]"));
            Assert.AreEqual("[[0,1],[2,3,4,5]]", Utils.Write2DArray(output));
        }
    }
}
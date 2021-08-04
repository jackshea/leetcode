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
    public class P0865_SmallestSubtreeWithAllTheDeepestNodesTests
    {
        [Test()]
        public void SubtreeWithAllDeepestTest()
        {
            var test = new P0865_SmallestSubtreeWithAllTheDeepestNodes();
            var input = Utils.BuildBinaryTree(new int?[] { 3, 5, 1, 6, 2, 0, 8, null, null, 7, 4 });
            var subtree = test.SubtreeWithAllDeepest(input);
            CollectionAssert.AreEquivalent(new int[] { 2, 7, 4 }, Utils.Traversal(subtree));

        }
    }
}
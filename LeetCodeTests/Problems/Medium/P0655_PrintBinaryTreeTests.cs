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
    public class P0655_PrintBinaryTreeTests
    {
        [Test()]
        public void PrintTreeTest()
        {
            var treeNode = ConvertArrayToBinaryTree.Build(new int?[] { 1, 2 });
            var test = new P0655_PrintBinaryTree();
            var printTree = test.PrintTree(treeNode);
            Assert.AreEqual("[[,1,],[2,,]]", Utils.Write2DArray(printTree));
        }
    }
}
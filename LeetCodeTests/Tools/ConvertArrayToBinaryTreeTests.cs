using NUnit.Framework;
using LeetCode.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Problems;

namespace LeetCode.Tools.Tests
{
    [TestFixture()]
    public class ConvertArrayToBinaryTreeTests
    {
        [Test()]
        public void BuildTest()
        {
            var values = new int?[] { 1, 2, 2, 3, 3, null, null, 4, 4 };
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(3);
            root.left.left.left = new TreeNode(4);
            root.left.left.right = new TreeNode(4);

            var binaryTree = ConvertArrayToBinaryTree.Build(values);
            var isSameTree = new P0100_SameTree().IsSameTree(binaryTree, root);

            Assert.IsTrue(isSameTree);
        }
    }
}
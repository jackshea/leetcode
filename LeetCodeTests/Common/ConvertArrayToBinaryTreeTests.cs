using LeetCode.Common;
using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Common
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

            var binaryTree = Utils.BuildBinaryTree(values);
            var isSameTree = new P0100_SameTree().IsSameTree(binaryTree, root);

            Assert.IsTrue(isSameTree);
        }
    }
}
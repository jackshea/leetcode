using LeetCode.Common;
using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0965_UnivaluedBinaryTreeTests
    {
        [Test()]
        public void IsUnivalTreeTest()
        {
            var test = new P0965_UnivaluedBinaryTree();
            var root = ConvertArrayToBinaryTree.Build(new int?[]{9, 9, 6, 9, 9});
            Assert.IsFalse(test.IsUnivalTree(root));
        }
    }
}
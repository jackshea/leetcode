using LeetCode.Common;
using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0111_MinimumDepthOfBinaryTreeTests
    {
        [Test()]
        public void MinDepthTest()
        {
            var values = new int?[] { 1, 2 };

            var root = Utils.BuildBinaryTree(values);

            Assert.AreEqual(2, new P0111_MinimumDepthOfBinaryTree().MinDepth(root));
        }
    }
}
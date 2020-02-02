using LeetCode.Common;
using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0110_BalancedBinaryTreeTests
    {
        [Test()]
        public void IsBalancedTest()
        {
            var values = new int?[] { 1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, null, null, 5, 5 };
            var root = ConvertArrayToBinaryTree.Build(values);

            Assert.IsTrue(new P0110_BalancedBinaryTree().IsBalanced(root));
        }
    }
}
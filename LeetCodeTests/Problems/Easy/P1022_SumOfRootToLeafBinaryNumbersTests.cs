using LeetCode.Common;
using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P1022_SumOfRootToLeafBinaryNumbersTests
    {
        [Test()]
        public void SumRootToLeafTest()
        {
            var input = new int?[] { 1, 0, 1, 0, 1, 0, 1 };
            var test = new P1022_SumOfRootToLeafBinaryNumbers();
            Assert.AreEqual(22, test.SumRootToLeaf(ConvertArrayToBinaryTree.Build(input)));
        }
    }
}
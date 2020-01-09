using NUnit.Framework;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Tools;

namespace LeetCode.Problems.Tests
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
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
    public class P0111_MinimumDepthOfBinaryTreeTests
    {
        [Test()]
        public void MinDepthTest()
        {
            var values = new int?[] { 1, 2 };

            var root = ConvertArrayToBinaryTree.Build(values);

            Assert.AreEqual(2, new P0111_MinimumDepthOfBinaryTree().MinDepth(root));
        }
    }
}
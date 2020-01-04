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
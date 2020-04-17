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
    public class P0143_ReorderListTests
    {
        [Test()]
        public void ReorderListTest()
        {
            var node = Utils.BuildList(new int[] { 1, 2, 3, 4 });
            var test = new P0143_ReorderList();
            test.ReorderList(node);
            Assert.AreEqual(new int[] { 1, 4, 2, 3 }, Utils.ListToArray(node));
        }
    }
}
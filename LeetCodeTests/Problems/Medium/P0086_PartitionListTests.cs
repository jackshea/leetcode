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
    public class P0086_PartitionListTests
    {
        [Test()]
        public void PartitionTest()
        {
            var list = Utils.BuildList(new int[] { 1, 4, 3, 2, 5, 2 });
            var test = new P0086_PartitionList();
            var actual = test.Partition(list, 3);
            Assert.AreEqual(new int[] { 1, 2, 2, 4, 3, 5 }, Utils.ListToArray(actual));
        }

        [Test()]
        public void PartitionTest1()
        {
            var list = Utils.BuildList(new int[] { 3, 1, 2 });
            var test = new P0086_PartitionList();
            var actual = test.Partition(list, 3);
            Assert.AreEqual(new int[] { 1, 2, 3 }, Utils.ListToArray(actual));
        }
    }
}
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
    public class P0082_RemoveDuplicatesFromSortedListIITests
    {
        [Test()]
        public void DeleteDuplicatesTest()
        {
            var list = Utils.BuildList(new[] { 1, 2, 3, 3, 4, 4, 5 });
            Assert.AreEqual(new int[] { 1, 2, 3, 3, 4, 4, 5 }, Utils.ListToArray(list));
        }

        [Test()]
        public void DeleteDuplicatesTest_1()
        {
            var test = new P0082_RemoveDuplicatesFromSortedListII();
            var list = Utils.BuildList(new[] { 1, 2, 3, 3, 4, 4, 5 });
            var actual = test.DeleteDuplicates(list);
            Assert.AreEqual(new int[] { 1, 2, 5 }, Utils.ListToArray(actual));
        }
    }
}
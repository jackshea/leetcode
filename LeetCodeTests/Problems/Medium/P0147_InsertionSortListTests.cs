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
    public class P0147_InsertionSortListTests
    {
        [Test()]
        public void InsertionSortListTest()
        {
            var list = Utils.BuildList(new[] { 4, 2, 1, 3 });
            var test = new P0147_InsertionSortList();
            var actual = test.InsertionSortList(list);
            Assert.AreEqual(new[] { 1, 2, 3, 4 }, Utils.ListToArray(actual));
        }
    }
}
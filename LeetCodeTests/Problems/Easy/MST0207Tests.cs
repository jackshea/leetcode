using NUnit.Framework;
using LeetCode.Problems.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode.Problems.Easy.Tests
{
    [TestFixture()]
    public class MST0207Tests
    {
        [Test()]
        public void GetIntersectionNodeTest()
        {
            ListNode common = Utils.BuildList(new[] { 8, 4, 5 });
            ListNode listA = Utils.BuildList(new[] { 4, 1 });
            ListNode listB = Utils.BuildList(new[] { 5, 0, 1 });
            Utils.ConnectList(listA, common);
            Utils.ConnectList(listB, common);
            var test = new MST0207();
            var intersectionNode = test.GetIntersectionNode(listA, listB);
            Assert.AreEqual(intersectionNode, common);
        }
    }
}
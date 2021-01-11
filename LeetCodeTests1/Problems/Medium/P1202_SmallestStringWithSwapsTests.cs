using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode.Problems.Medium.Tests
{
    [TestClass()]
    public class P1202_SmallestStringWithSwapsTests
    {
        [TestMethod()]
        public void SmallestStringWithSwapsTest()
        {
            var test = new P1202_SmallestStringWithSwaps();
            var result = test.SmallestStringWithSwaps("dcab", Utils.Read2DArray("[[0,3],[1,2],[0,2]]"));
            Assert.AreEqual("abcd", result);
        }
    }
}
using NUnit.Framework;
using LeetCode.Problems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Medium.Tests
{
    [TestFixture()]
    public class P0139_WordBreakTests
    {
        [Test()]
        public void WordBreakTest()
        {
            var test = new P0139_WordBreak();
            var actual = test.WordBreak("leetcode", new List<string> { "leet", "code" });
            Assert.IsTrue(actual);
        }
    }
}
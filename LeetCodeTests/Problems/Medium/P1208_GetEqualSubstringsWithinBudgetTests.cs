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
    public class P1208_GetEqualSubstringsWithinBudgetTests
    {
        [Test()]
        public void EqualSubstringTest()
        {
            var test = new P1208_GetEqualSubstringsWithinBudget();
            Assert.AreEqual(3, test.EqualSubstring("abcd", "bcdf", 3));
        }
    }
}
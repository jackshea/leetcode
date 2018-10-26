using NUnit.Framework;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems.Tests
{
    [TestFixture()]
    public class P0125_ValidPalindromeTests
    {
        [Test()]
        public void IsPalindromeTest()
        {
            Assert.IsTrue(new P0125_ValidPalindrome().IsPalindrome("A man, a plan, a canal: Panama"));
        }
    }
}
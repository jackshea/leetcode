using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
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
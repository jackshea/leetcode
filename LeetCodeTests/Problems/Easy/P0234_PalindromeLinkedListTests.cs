using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy
{
    [TestFixture()]
    public class P0234_PalindromeLinkedListTests
    {
        [Test()]
        public void IsPalindromeTest()
        {
            ListNode head=new ListNode(0);
            head.next=new ListNode(0);

            var isPalindrome = new P0234_PalindromeLinkedList().IsPalindrome(head);

            Assert.IsTrue(isPalindrome);
        }
    }
}
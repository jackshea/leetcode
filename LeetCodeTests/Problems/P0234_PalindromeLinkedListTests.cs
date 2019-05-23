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
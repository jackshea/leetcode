using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 回文链表
    /// https://leetcode-cn.com/problems/palindrome-linked-list/
    public class P0234_PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head?.next == null)
            {
                return true;
            }

            ListNode slow = head;
            ListNode fast = head;
            while (fast.next?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            slow = ReverseList(slow.next);

            while (slow != null)
            {
                if (head.val != slow.val)
                {
                    return false;
                }

                head = head.next;
                slow = slow.next;
            }

            return true;
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode curNode = head;
            ListNode preNode = null;
            while (curNode != null)
            {
                var postNode = curNode.next;
                curNode.next = preNode;
                preNode = curNode;
                curNode = postNode;
            }

            return preNode;
        }
    }
}
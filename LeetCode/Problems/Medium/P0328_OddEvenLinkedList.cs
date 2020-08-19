using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 奇偶链表
    /// https://leetcode-cn.com/problems/odd-even-linked-list/
    public class P0328_OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head?.next == null)
            {
                return head;
            }
            ListNode oddHead = head;
            ListNode evenHead = head.next;
            ListNode odd = oddHead;
            ListNode even = evenHead;
            while (odd?.next != null && even?.next != null)
            {
                odd.next = odd.next.next;
                odd = odd.next;
                even.next = even.next.next;
                even = even.next;
            }

            odd.next = evenHead;
            return oddHead;
        }
    }
}
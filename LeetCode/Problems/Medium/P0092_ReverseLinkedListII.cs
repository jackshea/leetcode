using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 反转链表 II
    /// https://leetcode-cn.com/problems/reverse-linked-list-ii/
    public class P0092_ReverseLinkedListII
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode fakeHead = new ListNode(0);
            fakeHead.next = head;
            ListNode cur = fakeHead;
            for (int i = 1; i < m && cur != null; i++)
            {
                cur = cur.next;
            }

            if (cur == null)
            {
                return head;
            }

            ListNode revHead = cur;
            cur = cur.next;
            ListNode revTail = cur;
            ListNode pre = null;
            ListNode next = null;
            for (int i = m; i <= n; i++)
            {
                next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }

            revHead.next = pre;
            revTail.next = cur;
            return fakeHead.next;
        }
    }
}
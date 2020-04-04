using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    public class P0061_RotateList
    {
        /// 旋转链表
        /// https://leetcode-cn.com/problems/rotate-list/
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head?.next == null)
            {
                return head;
            }

            ListNode cur = head;
            ListNode tail = head;
            int len = 1;

            while (tail != null && tail.next != null)
            {
                tail = tail.next;
                len++;
            }

            k %= len;
            if (k == 0)
            {
                return head;
            }
            for (int i = 1; i < len - k; i++)
            {
                cur = cur.next;
            }

            tail.next = head;
            ListNode next = cur.next;
            cur.next = null;
            return next;
        }
    }
}
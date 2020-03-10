using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 删除链表的倒数第N个节点
    /// https://leetcode-cn.com/problems/remove-nth-node-from-end-of-list/
    public class P0019_RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (n <= 0)
            {
                return head;
            }

            ListNode forward = head;
            ListNode last = head;
            int index = 0;
            while (forward != null)
            {
                if (index - n > 0)
                {
                    last = last.next;
                }

                forward = forward.next;
                index++;
            }

            if (index - n <= 0)
            {
                head = head.next;
            }
            else
            {
                last.next = last.next.next;
            }
            return head;
        }
    }
}
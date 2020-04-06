using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    public class P0086_PartitionList
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode fakeHead = new ListNode(x - 1);
            fakeHead.next = head;
            ListNode pre = fakeHead;
            while (pre.next != null)
            {
                if (pre.next.val >= x)
                {
                    break;
                }

                pre = pre.next;
            }

            if (pre.next == null)
            {
                return head;
            }

            ListNode cur = pre.next;
            while (cur.next != null)
            {
                if (cur.next.val < x)
                {
                    ListNode del = cur.next;
                    cur.next = cur.next.next;
                    del.next = pre.next;
                    pre.next = del;
                    pre = pre.next;
                }
                else
                {
                    cur = cur.next;
                }
            }

            return fakeHead.next;
        }
    }
}
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 分隔链表
    /// https://leetcode-cn.com/problems/partition-list/
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

    // 双链表实现，结构简单清晰
    public class P0086_PartitionList_1
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode greaterHead = new ListNode(0);
            ListNode lessHead = new ListNode(0);
            ListNode greaterNode = greaterHead;
            ListNode lessNode = lessHead;
            ListNode cur = head;
            while (cur != null)
            {
                if (cur.val < x)
                {
                    lessNode.next = cur;
                    lessNode = lessNode.next;
                }
                else
                {
                    greaterNode.next = cur;
                    greaterNode = greaterNode.next;
                }

                cur = cur.next;
            }

            greaterNode.next = null;
            lessNode.next = greaterHead.next;
            return lessHead.next;
        }
    }
}
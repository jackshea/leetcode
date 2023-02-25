using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 分割链表
/// https://leetcode-cn.com/problems/partition-list-lcci/
public class MST0204
{
    public ListNode Partition(ListNode head, int x)
    {
        var greaterHead = new ListNode(0);
        var lessHead = new ListNode(0);
        var greaterNode = greaterHead;
        var lessNode = lessHead;
        var cur = head;
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
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 反转链表 II
/// https://leetcode-cn.com/problems/reverse-linked-list-ii/
public class P0092_ReverseLinkedListII
{
    public ListNode ReverseBetween(ListNode head, int m, int n)
    {
        var fakeHead = new ListNode(0);
        fakeHead.next = head;
        var cur = fakeHead;
        for (var i = 1; i < m && cur != null; i++) cur = cur.next;

        if (cur == null) return head;

        var revHead = cur;
        cur = cur.next;
        var revTail = cur;
        ListNode pre = null;
        ListNode next = null;
        for (var i = m; i <= n; i++)
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
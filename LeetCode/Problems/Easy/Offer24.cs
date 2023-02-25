using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 24. 反转链表
/// https://leetcode-cn.com/problems/fan-zhuan-lian-biao-lcof/
public class Offer24
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode pre = null;
        var cur = head;
        while (cur != null)
        {
            var next = cur.next;
            cur.next = pre;
            pre = cur;
            cur = next;
        }

        return pre;
    }
}
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 链表求和
/// https://leetcode-cn.com/problems/sum-lists-lcci/
public class MST0205
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return AddTwoNumbers(l1, l2, 0);
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry)
    {
        if (l1 == null && l2 == null && carry == 0) return null;

        var v = carry;
        if (l1 != null) v += l1.val;

        if (l2 != null) v += l2.val;

        carry = v / 10;
        v %= 10;
        var ans = new ListNode(v);
        ans.next = AddTwoNumbers(l1?.next, l2?.next, carry);
        return ans;
    }
}
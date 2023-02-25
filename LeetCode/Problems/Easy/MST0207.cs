using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 链表相交
/// https://leetcode-cn.com/problems/intersection-of-two-linked-lists-lcci/
public class MST0207
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var lenA = Length(headA);
        var lenB = Length(headB);
        if (lenA > lenB)
            headA = Forward(headA, lenA - lenB);
        else
            headB = Forward(headB, lenB - lenA);

        while (headA != null)
        {
            if (headA == headB) return headA;

            headA = headA.next;
            headB = headB.next;
        }

        return null;
    }

    private int Length(ListNode list)
    {
        var len = 0;
        while (list != null)
        {
            len++;
            list = list.next;
        }

        return len;
    }

    private ListNode Forward(ListNode list, int k)
    {
        for (var i = 0; i < k; i++)
            if (list != null)
                list = list.next;

        return list;
    }
}
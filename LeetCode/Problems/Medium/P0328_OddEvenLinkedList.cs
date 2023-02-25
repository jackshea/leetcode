using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 奇偶链表
/// https://leetcode-cn.com/problems/odd-even-linked-list/
public class P0328_OddEvenLinkedList
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head?.next == null) return head;
        var oddHead = head;
        var evenHead = head.next;
        var odd = oddHead;
        var even = evenHead;
        while (odd?.next != null && even?.next != null)
        {
            odd.next = odd.next.next;
            odd = odd.next;
            even.next = even.next.next;
            even = even.next;
        }

        odd.next = evenHead;
        return oddHead;
    }
}
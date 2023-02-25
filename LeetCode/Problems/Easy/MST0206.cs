using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 回文链表
/// https://leetcode-cn.com/problems/palindrome-linked-list-lcci/
public class MST0206
{
    public bool IsPalindrome(ListNode head)
    {
        if (head?.next == null) return true;

        var fast = head;
        var slow = head;
        while (fast.next?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        slow = ReverseList(slow.next);
        while (slow != null)
        {
            if (head.val != slow.val) return false;

            head = head.next;
            slow = slow.next;
        }

        return true;
    }

    private ListNode ReverseList(ListNode head)
    {
        var cur = head;
        ListNode pre = null;
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
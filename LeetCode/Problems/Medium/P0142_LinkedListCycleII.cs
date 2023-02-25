using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 环形链表 II
/// https://leetcode-cn.com/problems/linked-list-cycle-ii/
public class P0142_LinkedListCycleII
{
    public ListNode DetectCycle(ListNode head)
    {
        var isCycle = false;
        var fast = head;
        var slow = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if (fast == slow)
            {
                isCycle = true;
                break;
            }
        }

        if (!isCycle) return null;

        var cur = head;
        while (cur != slow)
        {
            cur = cur.next;
            slow = slow.next;
        }

        return cur;
    }
}
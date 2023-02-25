using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 环路检测
/// https://leetcode-cn.com/problems/linked-list-cycle-lcci/
public class MST0208
{
    public ListNode DetectCycle(ListNode head)
    {
        var slow = head;
        var fast = head;
        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                fast = head;
                while (fast != slow)
                {
                    fast = fast.next;
                    slow = slow.next;
                }

                return fast;
            }
        }

        return null;
    }
}
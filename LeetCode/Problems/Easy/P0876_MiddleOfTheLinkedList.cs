using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 链表的中间结点
/// https://leetcode-cn.com/problems/middle-of-the-linked-list/
public class P0876_MiddleOfTheLinkedList
{
    public ListNode MiddleNode(ListNode head)
    {
        var fast = head;
        var slow = head;
        while (fast != null)
        {
            fast = fast.next;
            if (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            else
            {
                break;
            }
        }

        return slow;
    }
}
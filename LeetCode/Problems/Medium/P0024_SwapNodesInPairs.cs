using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 两两交换链表中的节点
/// https://leetcode-cn.com/problems/swap-nodes-in-pairs/
public class P0024_SwapNodesInPairs
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head?.next == null) return head;

        var temp = head.next;
        head.next = SwapPairs(temp.next);
        temp.next = head;
        return temp;
    }
}
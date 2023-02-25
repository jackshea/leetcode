using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 52. 两个链表的第一个公共节点
/// https://leetcode-cn.com/problems/liang-ge-lian-biao-de-di-yi-ge-gong-gong-jie-dian-lcof/
public class Offer52
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;

        var nodeA = headA;
        var nodeB = headB;
        while (nodeA != nodeB)
        {
            nodeA = nodeA == null ? headB : nodeA.next;
            nodeB = nodeB == null ? headA : nodeB.next;
        }

        return nodeA;
    }
}
﻿using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 相交链表
/// https://leetcode-cn.com/problems/intersection-of-two-linked-lists/description/
public class P0160_IntersectionOfTwoLinkedLists
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
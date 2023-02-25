using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 合并两个链表
/// https://leetcode.cn/problems/merge-in-between-linked-lists/
public class P1669_MergeInBetweenLinkedLists
{
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
    {
        var l2End = list2;
        while (l2End.next != null) l2End = l2End.next;
        var node1 = list1;
        var preA = list1;
        var postB = list1;

        var index = 0;
        while (node1 != null)
        {
            if (index == a - 1)
                preA = node1;
            else if (index == b + 1) postB = node1;

            node1 = node1.next;
            index++;
        }

        preA.next = list2;
        l2End.next = postB;

        return list1;
    }
}
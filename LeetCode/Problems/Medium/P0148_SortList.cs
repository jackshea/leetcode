using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 排序链表
/// https://leetcode-cn.com/problems/sort-list/
public class P0148_SortList
{
    public ListNode SortList(ListNode head)
    {
        return MergeSort(head);
    }

    public ListNode MergeSort(ListNode node)
    {
        if (node?.next == null) return node;

        var slow = node;
        var fast = node;
        while (fast != null && fast.next != null && fast.next.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        var next = slow.next;
        slow.next = null;
        slow = next;
        return Merge(MergeSort(node), MergeSort(slow));
    }

    public ListNode Merge(ListNode left, ListNode right)
    {
        var fakeHead = new ListNode(0);
        var cur = fakeHead;
        while (left != null && right != null)
        {
            if (left.val <= right.val)
            {
                cur.next = left;
                left = left.next;
            }
            else
            {
                cur.next = right;
                right = right.next;
            }

            cur = cur.next;
        }

        if (left != null) cur.next = left;

        if (right != null) cur.next = right;

        return fakeHead.next;
    }
}
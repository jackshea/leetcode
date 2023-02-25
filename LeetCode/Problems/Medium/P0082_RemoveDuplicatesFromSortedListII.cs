using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 删除排序链表中的重复元素 II
/// https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list-ii/
public class P0082_RemoveDuplicatesFromSortedListII
{
    private int? repeatNum;

    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null || head.next == null) return head;

        head.next = DeleteDuplicates(head.next);

        if (head != null && head.next != null && head.val == head.next.val) repeatNum = head.val;

        while (repeatNum.HasValue && head != null && head.val == repeatNum) head = head.next;

        return head;
    }
}
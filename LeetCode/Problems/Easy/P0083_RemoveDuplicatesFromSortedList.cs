namespace LeetCode.Problems.Easy
{
    /// 删除排序链表中的重复元素
    /// https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list/description/
    public class P0083_RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode current = head;
            while (current.next != null)
            {
                if (current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return head;
        }
    }
}
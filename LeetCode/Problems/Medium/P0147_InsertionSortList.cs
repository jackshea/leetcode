using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 对链表进行插入排序
    /// https://leetcode-cn.com/problems/insertion-sort-list/
    public class P0147_InsertionSortList
    {
        public ListNode InsertionSortList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode fakeHead = new ListNode(int.MinValue);
            fakeHead.next = head;
            ListNode sorted = head;
            ListNode unsorted = head.next;
            while (unsorted != null)
            {
                if (unsorted.val >= sorted.val)
                {
                    sorted = unsorted;
                    unsorted = unsorted.next;
                    continue;
                }

                head = fakeHead;
                while (head.next.val < unsorted.val)
                {
                    head = head.next;
                }

                sorted.next = unsorted.next;
                unsorted.next = head.next;
                head.next = unsorted;
                unsorted = sorted.next;
            }

            return fakeHead.next;
        }
    }
}
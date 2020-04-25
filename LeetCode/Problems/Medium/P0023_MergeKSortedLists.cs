using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 合并K个排序链表
    /// https://leetcode-cn.com/problems/merge-k-sorted-lists/
    public class P0023_MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
            {
                return null;
            }

            ListNode ans = lists[0];
            for (int i = 1; i < lists.Length; i++)
            {
                ans = MergeTwoLists(ans, lists[i]);
            }

            return ans;
        }

        public ListNode MergeTwoLists(ListNode a, ListNode b)
        {
            ListNode fakeHead = new ListNode(0);
            ListNode cur = fakeHead;
            while (a != null && b != null)
            {
                if (a.val <= b.val)
                {
                    cur.next = a;
                    cur = a;
                    a = a.next;
                }
                else
                {
                    cur.next = b;
                    cur = b;
                    b = b.next;
                }
            }
            if (a != null)
            {
                cur.next = a;
            }
            if (b != null)
            {
                cur.next = b;
            }

            return fakeHead.next;
        }
    }
}
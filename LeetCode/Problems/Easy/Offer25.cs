using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 25. 合并两个排序的链表
    /// https://leetcode-cn.com/problems/he-bing-liang-ge-pai-xu-de-lian-biao-lcof/
    public class Offer25
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode ans = new ListNode(-1);
            ListNode cur = ans;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }

                cur = cur.next;
            }

            if (l1 != null)
            {
                cur.next = l1;
            }

            if (l2 != null)
            {
                cur.next = l2;
            }

            return ans.next;
        }
    }
}
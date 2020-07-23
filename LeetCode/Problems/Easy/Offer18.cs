using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 18. 删除链表的节点
    /// https://leetcode-cn.com/problems/shan-chu-lian-biao-de-jie-dian-lcof/
    public class Offer18
    {
        public ListNode DeleteNode(ListNode head, int val)
        {
            if (head.val == val)
            {
                return head.next;
            }

            ListNode cur = head;
            while (cur.next != null)
            {
                if (cur.next.val == val)
                {
                    cur.next = cur.next.next;
                    break;
                }

                cur = cur.next;
            }

            return head;
        }
    }
}
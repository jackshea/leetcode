using System.Collections;
using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 06. 从尾到头打印链表
    /// https://leetcode-cn.com/problems/cong-wei-dao-tou-da-yin-lian-biao-lcof/
    public class Offer06
    {
        public int[] ReversePrint(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            ListNode cur = head;
            while (cur != null)
            {
                stack.Push(cur.val);
                cur = cur.next;
            }

            return stack.ToArray();
        }
    }
}
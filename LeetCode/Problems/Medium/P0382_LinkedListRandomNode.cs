using System;
using LeetCode.Common;

namespace LeetCode.Problems.Medium.P0382
{
    /// 链表随机节点
    /// https://leetcode-cn.com/problems/linked-list-random-node/
    public class Solution
    {
        private ListNode head;
        private Random rand = new Random();

        /** @param head The linked list's head.
            Note that the head is guaranteed to be not null, so it contains at least one node. */
        public Solution(ListNode head)
        {
            this.head = head;
        }

        /** Returns a random node's value. */
        public int GetRandom()
        {
            int count = 0;
            int reserveNum = 0;
            ListNode curr = head;
            while (curr != null)
            {
                count++;
                if (rand.Next(count) == 0)
                {
                    reserveNum = curr.val;
                }

                curr = curr.next;
            }

            return reserveNum;
        }
    }
}
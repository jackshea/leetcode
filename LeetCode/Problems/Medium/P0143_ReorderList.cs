﻿using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 重排链表
    /// https://leetcode-cn.com/problems/reorder-list/
    public class P0143_ReorderList
    {
        public void ReorderList(ListNode head)
        {
            if (head == null)
            {
                return;
            }

            // 找到中间结点
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            if (slow == head)
            {
                return;
            }

            // 反转后半部分的结点
            ListNode pre = null;
            while (slow != null)
            {
                ListNode next = slow.next;
                slow.next = pre;
                pre = slow;
                slow = next;
            }

            ListNode postList = pre;

            // 合并前半部分和后半部分
            ListNode cur = head;
            while (postList != null)
            {
                ListNode slowNext = postList.next;
                postList.next = cur.next;
                cur.next = postList;
                cur = cur.next.next;
                postList = slowNext;
            }

            cur.next = null;
        }
    }
}
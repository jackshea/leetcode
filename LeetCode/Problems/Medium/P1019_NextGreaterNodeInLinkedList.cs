using LeetCode.Common;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 链表中的下一个更大节点
/// https://leetcode.cn/problems/next-greater-node-in-linked-list/
public class P1019_NextGreaterNodeInLinkedList
{
    public int[] NextLargerNodes(ListNode head)
    {
        Stack<ListNodeWithIndex> stack=new Stack<ListNodeWithIndex>();
        List<int> ans=new List<int>();
        ListNode cur=head;
        int index = 0;
        while (cur != null)
        {
            ans.Add(0);
            while (stack.TryPeek(out var top) && top.node.val<cur.val)
            {
                ans[top.index] = cur.val;
                stack.Pop();
            }

            stack.Push(new ListNodeWithIndex{node = cur,index = index});

            cur = cur.next;
            index++;
        }
        return ans.ToArray();
    }

    public class ListNodeWithIndex
    {
        public ListNode node;
        public int index;
    }
}
using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 移除重复节点
/// https://leetcode-cn.com/problems/remove-duplicate-node-lcci/
public class MST0201
{
    public ListNode RemoveDuplicateNodes(ListNode head)
    {
        if (head == null) return head;
        var cur = head;
        var set = new HashSet<int>();
        set.Add(cur.val);
        while (cur.next != null)
            if (set.Contains(cur.next.val))
            {
                cur.next = cur.next.next;
            }
            else
            {
                set.Add(cur.next.val);
                cur = cur.next;
            }

        return head;
    }
}
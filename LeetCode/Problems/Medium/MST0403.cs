using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 特定深度节点链表
/// https://leetcode-cn.com/problems/list-of-depth-lcci/
public class MST0403
{
    public ListNode[] ListOfDepth(TreeNode tree)
    {
        var ans = new List<ListNode>();
        var q = new Queue<TreeNode>();
        q.Enqueue(tree);
        while (q.Count != 0)
        {
            var count = q.Count;
            var row = new ListNode(-1);
            var cur = row;
            for (var i = 0; i < count; i++)
            {
                var top = q.Dequeue();
                if (top.left != null) q.Enqueue(top.left);

                if (top.right != null) q.Enqueue(top.right);

                cur.next = new ListNode(top.val);
                cur = cur.next;
            }

            ans.Add(row.next);
        }

        return ans.ToArray();
    }
}
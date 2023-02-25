using System;
using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 在每个树行中找最大值
/// https://leetcode-cn.com/problems/find-largest-value-in-each-tree-row/
public class P0515_FindLargestValueInEachTreeRow
{
    public IList<int> LargestValues(TreeNode root)
    {
        IList<int> ans = new List<int>();
        if (root == null) return ans;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            var max = int.MinValue;
            var count = q.Count;
            for (var i = 0; i < count; i++)
            {
                var top = q.Dequeue();
                max = Math.Max(max, top.val);
                if (top.left != null) q.Enqueue(top.left);
                if (top.right != null) q.Enqueue(top.right);
            }

            ans.Add(max);
        }

        return ans;
    }
}
using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 32 - II. 从上到下打印二叉树 II
/// https://leetcode-cn.com/problems/cong-shang-dao-xia-da-yin-er-cha-shu-ii-lcof/
public class Offer32_II
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        if (root == null) return ans;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count != 0)
        {
            var count = q.Count;
            IList<int> row = new List<int>();
            for (var i = 0; i < count; i++)
            {
                var top = q.Dequeue();
                row.Add(top.val);
                if (top.left != null) q.Enqueue(top.left);
                if (top.right != null) q.Enqueue(top.right);
            }

            ans.Add(row);
        }

        return ans;
    }
}
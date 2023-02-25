using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 二叉树的层平均值
/// https://leetcode-cn.com/problems/average-of-levels-in-binary-tree/
public class P0637_AverageOfLevelsInBinaryTree
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        IList<double> result = new List<double>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count != 0)
        {
            var count = q.Count;
            double sum = 0;
            for (var i = 0; i < count; i++)
            {
                var top = q.Dequeue();
                sum += top.val;
                if (top.left != null) q.Enqueue(top.left);
                if (top.right != null) q.Enqueue(top.right);
            }

            result.Add(sum / count);
        }

        return result;
    }
}
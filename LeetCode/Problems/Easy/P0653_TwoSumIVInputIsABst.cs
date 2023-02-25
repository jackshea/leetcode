using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 两数之和 IV - 输入 BST
/// https://leetcode-cn.com/problems/two-sum-iv-input-is-a-bst/
public class P0653_TwoSumIVInputIsABst
{
    private readonly List<int> sorted = new();

    public bool FindTarget(TreeNode root, int k)
    {
        Traversal(root);
        var left = 0;
        var right = sorted.Count - 1;
        while (left < right)
        {
            var sum = sorted[left] + sorted[right];

            if (sum == k)
                return true;
            if (sum < k)
                left++;
            else
                right--;
        }

        return false;
    }

    private void Traversal(TreeNode node)
    {
        if (node == null) return;

        Traversal(node.left);
        sorted.Add(node.val);
        Traversal(node.right);
    }
}
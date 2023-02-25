using System;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 平衡二叉树
/// https://leetcode-cn.com/problems/balanced-binary-tree/description/
public class P0110_BalancedBinaryTree
{
    private bool judge = true;

    public bool IsBalanced(TreeNode root)
    {
        maxDepth(root);
        return judge;
    }

    private int maxDepth(TreeNode node)
    {
        if (node == null || !judge) return 0;

        var l = maxDepth(node.left);
        var r = maxDepth(node.right);
        if (Math.Abs(l - r) > 1) judge = false;

        return 1 + Math.Max(l, r);
    }
}
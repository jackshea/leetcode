using System;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 55 - II. 平衡二叉树
/// https://leetcode-cn.com/problems/ping-heng-er-cha-shu-lcof/
public class Offer55_II
{
    public bool IsBalanced(TreeNode root)
    {
        return DFS(root) != -1;
    }

    private int DFS(TreeNode root)
    {
        if (root == null) return 0;

        var left = DFS(root.left);
        if (left == -1) return -1;

        var right = DFS(root.right);
        if (right == -1) return -1;
        if (Math.Abs(left - right) <= 1) return Math.Max(left, right) + 1;

        return -1;
    }
}
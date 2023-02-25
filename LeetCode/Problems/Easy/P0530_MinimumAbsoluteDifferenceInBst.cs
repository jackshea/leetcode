using System;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 二叉搜索树的最小绝对差
/// https://leetcode-cn.com/problems/minimum-absolute-difference-in-bst/
public class P0530_MinimumAbsoluteDifferenceInBst
{
    private int miniDiff = int.MaxValue;
    private TreeNode preNode;

    public int GetMinimumDifference(TreeNode root)
    {
        Travel(root);
        return miniDiff;
    }

    private void Travel(TreeNode node)
    {
        if (node == null) return;

        Travel(node.left);
        if (preNode != null) miniDiff = Math.Min(miniDiff, Math.Abs(node.val - preNode.val));
        preNode = node;
        Travel(node.right);
    }
}
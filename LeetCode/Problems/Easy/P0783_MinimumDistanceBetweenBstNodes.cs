using System;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 二叉搜索树结点最小距离
/// https://leetcode-cn.com/problems/minimum-distance-between-bst-nodes/
public class P0783_MinimumDistanceBetweenBstNodes
{
    private int minDist = int.MaxValue;
    private TreeNode preNode;

    public int MinDiffInBST(TreeNode root)
    {
        Traveral(root);
        return minDist;
    }

    private void Traveral(TreeNode node)
    {
        if (node == null) return;

        Traveral(node.left);
        if (preNode != null) minDist = Math.Min(minDist, node.val - preNode.val);

        preNode = node;
        Traveral(node.right);
    }
}
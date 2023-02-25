using System;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 二叉树的直径
/// https://leetcode-cn.com/problems/diameter-of-binary-tree/
public class P0543_DiameterOfBinaryTree
{
    private int diameter;

    public int DiameterOfBinaryTree(TreeNode root)
    {
        Height(root);
        return diameter;
    }

    public int Height(TreeNode node)
    {
        if (node == null) return 0;

        var leftTreeHeight = Height(node.left);
        var rightTreeHeight = Height(node.right);

        diameter = Math.Max(diameter, leftTreeHeight + rightTreeHeight);

        return 1 + Math.Max(leftTreeHeight, rightTreeHeight);
    }
}
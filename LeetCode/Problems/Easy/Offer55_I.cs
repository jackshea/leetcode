using System;
using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 55 - I. 二叉树的深度
/// https://leetcode-cn.com/problems/er-cha-shu-de-shen-du-lcof/
public class Offer55_I
{
    public int MaxDepth(TreeNode root)
    {
        return root == null ? 0 : 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}
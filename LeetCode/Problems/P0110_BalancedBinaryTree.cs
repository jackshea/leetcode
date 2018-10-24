﻿using System;

namespace LeetCode.Problems
{
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
            if (node == null || !judge)
            {
                return 0;
            }

            int l = maxDepth(node.left);
            int r = maxDepth(node.right);
            if (Math.Abs(l - r) > 1)
            {
                judge = false;
            }

            return 1 + Math.Max(l, r);
        }
    }
}
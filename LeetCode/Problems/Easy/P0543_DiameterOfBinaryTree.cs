using System;

namespace LeetCode.Problems
{
    /// 二叉树的直径
    /// https://leetcode-cn.com/problems/diameter-of-binary-tree/
    public class P0543_DiameterOfBinaryTree
    {
        private int diameter = 0;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            Height(root);
            return diameter;
        }

        public int Height(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftTreeHeight = Height(node.left);
            int rightTreeHeight = Height(node.right);

            diameter = Math.Max(diameter, leftTreeHeight + rightTreeHeight);

            return 1 + Math.Max(leftTreeHeight, rightTreeHeight);
        }
    }
}
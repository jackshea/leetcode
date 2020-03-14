using LeetCode.Common;
using System;

namespace LeetCode.Problems.Easy
{
    /// 二叉树的最小深度
    /// https://leetcode-cn.com/problems/minimum-depth-of-binary-tree/description/
    public class P0111_MinimumDepthOfBinaryTree
    {
        private int minDepth = Int32.MaxValue;

        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            Traversal(root, 1);
            return minDepth;
        }

        private void Traversal(TreeNode node, int depth)
        {
            if (node == null)
            {
                return;
            }

            if (depth > minDepth)
            {
                return;
            }

            if (node.left == null && node.right == null)
            {
                minDepth = depth;
                return;
            }

            Traversal(node.left, depth + 1);
            Traversal(node.right, depth + 1);
        }
    }

    public class P0111_MinimumDepthOfBinaryTree_1
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.left == null && root.right == null)
            {
                return 1;
            }

            if (root.left == null)
            {
                return 1 + MinDepth(root.right);
            }

            if (root.right == null)
            {
                return 1 + MinDepth(root.left);
            }

            return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
        }
    }
}
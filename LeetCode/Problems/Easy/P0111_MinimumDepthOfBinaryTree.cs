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

            Traval(root, 1);
            return minDepth;
        }

        private void Traval(TreeNode node, int depth)
        {
            if (node == null)
            {
                return;
            }

            if (node.left == null && node.right == null)
            {
                minDepth = Math.Min(minDepth, depth);
                return;
            }

            Traval(node.left, depth + 1);
            Traval(node.right, depth + 1);
        }
    }
}
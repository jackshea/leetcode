using System;

namespace LeetCode.Problems.Easy
{
    /// 二叉树中第二小的节点
    /// https://leetcode-cn.com/problems/second-minimum-node-in-a-binary-tree/
    public class P0671_SecondMinimumNodeInABinaryTree
    {
        public int FindSecondMinimumValue(TreeNode root)
        {
            return Min(root, root.val);
        }

        private int Min(TreeNode tn, int mini)
        {
            if (tn == null)
            {
                return -1;
            }

            if (tn.val > mini)
            {
                return tn.val;
            }

            var left = Min(tn.left, mini);
            var right = Min(tn.right, mini);
            if (left == -1)
            {
                return right;
            }
            if (right == -1)
            {
                return left;
            }

            return Math.Min(left, right);
        }
    }
}
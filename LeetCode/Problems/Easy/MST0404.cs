using System;
using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 检查平衡性
    /// https://leetcode-cn.com/problems/check-balance-lcci/
    public class MST0404
    {
        private bool isBalanced = true;
        public bool IsBalanced(TreeNode root)
        {
            Height(root);
            return isBalanced;
        }

        private int Height(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = Height(root.left);
            int right = Height(root.right);
            if (Math.Abs(left - right) > 1)
            {
                isBalanced = false;
            }

            return 1 + Math.Max(left, right);
        }
    }
}
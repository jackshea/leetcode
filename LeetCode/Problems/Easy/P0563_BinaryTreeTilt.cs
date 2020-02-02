using System;

namespace LeetCode.Problems.Easy
{
    /// 二叉树的坡度
    /// https://leetcode-cn.com/problems/binary-tree-tilt/
    public class P0563_BinaryTreeTilt
    {
        private int result = 0;
        public int FindTilt(TreeNode root)
        {
            Sum(root);
            return result;
        }

        private int Sum(TreeNode node)
        {
            if (node==null)
            {
                return 0;
            }

            int left = Sum(node.left);
            int right = Sum(node.right);
            result += Math.Abs(left - right);
            return left + right + node.val;
        }
    }
}
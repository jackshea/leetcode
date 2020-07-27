using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 28. 对称的二叉树
    /// https://leetcode-cn.com/problems/dui-cheng-de-er-cha-shu-lcof/
    public class Offer28
    {
        public bool IsSymmetric(TreeNode root)
        {
            return root == null || IsMirror(root.left, root.right);
        }

        private bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }

            if (left == null || right == null || left.val != right.val)
            {
                return false;
            }

            return IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
        }
    }
}
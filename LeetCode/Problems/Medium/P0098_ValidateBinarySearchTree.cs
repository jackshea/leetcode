using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 验证二叉搜索树
    /// https://leetcode-cn.com/problems/validate-binary-search-tree/
    public class P0098_ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, long.MinValue, long.MaxValue);
        }

        private bool IsValidBST(TreeNode root, long min, long max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.val <= min || root.val >= max)
            {
                return false;
            }

            return IsValidBST(root.left, min, root.val) && IsValidBST(root.right, root.val, max);
        }
    }
}
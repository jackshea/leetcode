using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 合法二叉搜索树
    /// https://leetcode-cn.com/problems/legal-binary-search-tree-lcci/
    public class MST0405
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, long.MinValue, long.MaxValue);
        }

        public bool IsValidBST(TreeNode root, long min, long max)
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
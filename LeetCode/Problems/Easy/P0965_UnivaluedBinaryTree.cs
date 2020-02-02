namespace LeetCode.Problems.Easy
{
    /// 单值二叉树
    /// https://leetcode-cn.com/problems/univalued-binary-tree/
    public class P0965_UnivaluedBinaryTree
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            if (root.left != null && (root.val != root.left.val || !IsUnivalTree(root.left))) return false;
            if (root.right != null && (root.val != root.right.val || !IsUnivalTree(root.right))) return false;
            return true;
        }
    }
}
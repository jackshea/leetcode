using LeetCode.Problems.Easy;

namespace LeetCode.Problems.Medium
{
    /// 二叉树的最近公共祖先
    /// https://leetcode-cn.com/problems/lowest-common-ancestor-of-a-binary-tree/
    public class P0236_LowestCommonAncestorOfABinaryTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
            {
                return null;
            }

            if (p == root || q == root)
            {
                return root;
            }

            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);
            if (left == null)
            {
                return right;
            }

            if (right == null)
            {
                return left;
            }

            return root;
        }
    }
}
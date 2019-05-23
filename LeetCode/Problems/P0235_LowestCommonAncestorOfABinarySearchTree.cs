namespace LeetCode.Problems
{
    /// 二叉搜索树的最近公共祖先
    /// https://leetcode-cn.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
    public class P0235_LowestCommonAncestorOfABinarySearchTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val < root.val && q.val < root.val)
            {
                return LowestCommonAncestor(root.left, p, q);
            }

            if (p.val > root.val && q.val > root.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }

            return root;
        }
    }
}
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 首个共同祖先
/// https://leetcode-cn.com/problems/first-common-ancestor-lcci/
public class MST0408
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null || root == p || root == q) return root;

        var left = LowestCommonAncestor(root.left, p, q);
        var right = LowestCommonAncestor(root.right, p, q);
        if (left != null && right != null) return root;

        return left ?? right;
    }
}
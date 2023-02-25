using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 修剪二叉搜索树
/// https://leetcode-cn.com/problems/trim-a-binary-search-tree/
public class P0669_TrimABinarySearchTree
{
    public TreeNode TrimBST(TreeNode root, int L, int R)
    {
        if (root == null) return null;

        if (root.val < L) return TrimBST(root.right, L, R);

        if (root.val > R) return TrimBST(root.left, L, R);

        root.left = TrimBST(root.left, L, R);
        root.right = TrimBST(root.right, L, R);
        return root;
    }
}
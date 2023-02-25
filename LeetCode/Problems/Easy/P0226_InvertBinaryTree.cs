using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 翻转二叉树
/// https://leetcode-cn.com/problems/invert-binary-tree/submissions/
public class P0226_InvertBinaryTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;

        var temp = root.left;
        root.left = root.right;
        root.right = temp;
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }
}
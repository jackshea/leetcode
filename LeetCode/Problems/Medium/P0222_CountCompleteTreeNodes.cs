using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 完全二叉树的节点个数
/// https://leetcode-cn.com/problems/count-complete-tree-nodes/
public class P0222_CountCompleteTreeNodes
{
    public int CountNodes(TreeNode root)
    {
        if (IsPerfectTree(root))
        {
            var count = 1;
            var right = root;
            while (right != null)
            {
                count *= 2;
                right = right.right;
            }

            return count - 1;
        }

        return CountNodes(root.left) + CountNodes(root.right) + 1;
    }

    public bool IsPerfectTree(TreeNode root)
    {
        if (root == null) return true;
        var left = root;
        var right = root;
        if (left != null && right != null)
        {
            left = left.left;
            right = right.right;
        }

        return left == null && right == null;
    }
}
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 二叉树剪枝
    /// https://leetcode-cn.com/problems/binary-tree-pruning/
    public class P0814_BinaryTreePruning
    {
        public TreeNode PruneTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);
            if (root.left == null && root.right == null && root.val == 0)
            {
                root = null;
            }

            return root;
        }
    }
}
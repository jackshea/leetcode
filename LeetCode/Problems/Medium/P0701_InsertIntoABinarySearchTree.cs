using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 二叉搜索树中的插入操作
    /// https://leetcode-cn.com/problems/insert-into-a-binary-search-tree/
    public class P0701_InsertIntoABinarySearchTree
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return new TreeNode(val);
            }

            if (val < root.val)
            {
                root.left = InsertIntoBST(root.left, val);
            }
            else
            {
                root.right = InsertIntoBST(root.right, val);
            }

            return root;
        }
    }
}
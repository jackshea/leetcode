namespace LeetCode.Problems
{
    /// 二叉搜索树中的搜索
    /// https://leetcode-cn.com/problems/search-in-a-binary-search-tree/
    public class P0700_SearchInABinarySearchTree
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
            {
                return null;
            }

            if (root.val == val)
            {
                return root;
            }
            else if (root.val > val)
            {
                return SearchBST(root.left, val);
            }
            else
            {
                return SearchBST(root.right, val);
            }
        }
    }
}
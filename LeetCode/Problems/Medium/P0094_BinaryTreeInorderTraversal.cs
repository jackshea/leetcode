using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 二叉树的中序遍历
    /// https://leetcode-cn.com/problems/binary-tree-inorder-traversal/
    public class P0094_BinaryTreeInorderTraversal
    {
        private IList<int> ans = new List<int>();
        public IList<int> InorderTraversal(TreeNode root)
        {
            DFS(root);
            return ans;
        }

        private void DFS(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            DFS(node.left);
            ans.Add(node.val);
            DFS(node.right);
        }
    }
}
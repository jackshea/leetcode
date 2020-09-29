using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 二叉树的后序遍历
    /// https://leetcode-cn.com/problems/binary-tree-postorder-traversal/
    public class P0145_BinaryTreePostorderTraversal
    {
        private IList<int> ans = new List<int>();
        public IList<int> PostorderTraversal(TreeNode root)
        {
            Traversal(root);
            return ans;
        }

        public void Traversal(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Traversal(node.left);
            Traversal(node.right);
            ans.Add(node.val);
        }
    }
}
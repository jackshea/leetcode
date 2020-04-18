using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 二叉树的前序遍历
    /// https://leetcode-cn.com/problems/binary-tree-preorder-traversal/
    public class P0144_BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> ans = new List<int>();
            if (root == null)
            {
                return ans;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count != 0)
            {
                var top = stack.Pop();
                ans.Add(top.val);
                if (top.right != null)
                {
                    stack.Push(top.right);
                }
                if (top.left != null)
                {
                    stack.Push(top.left);
                }
            }

            return ans;
        }
    }
}
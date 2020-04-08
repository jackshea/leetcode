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

    /// 非递归
    public class P0094_BinaryTreeInorderTraversal_1
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> ans = new List<int>();
            if (root == null)
            {
                return ans;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            TreeNode cur = root;

            while (stack.Count != 0)
            {
                while (cur.left != null)
                {
                    stack.Push(cur.left);
                    cur = cur.left;
                }
                while (stack.Count != 0)
                {
                    var node = stack.Pop();
                    ans.Add(node.val);
                    if (node.right != null)
                    {
                        stack.Push(node.right);
                        cur = node.right;
                        break;
                    }
                }
            }
            return ans;
        }
    }
}
using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 二叉树的后序遍历
    /// https://leetcode-cn.com/problems/binary-tree-postorder-traversal/
    public class P0145_BinaryTreePostorderTraversal
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            IList<int> ans = new List<int>();
            if (root == null)
            {
                return ans;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode pre = null;
            TreeNode cur = root;
            while (cur != null || stack.Count != 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }

                cur = stack.Pop();
                if (cur.right == null || cur.right == pre)
                {
                    ans.Add(cur.val);
                    pre = cur;
                    cur = null;
                }
                else
                {
                    stack.Push(cur);
                    cur = cur.right;
                }
            }

            return ans;
        }
    }


    // 递归写法
    public class P0145_BinaryTreePostorderTraversal1
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
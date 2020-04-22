using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 二叉搜索树迭代器
    /// https://leetcode-cn.com/problems/binary-search-tree-iterator/
    public class BSTIterator
    {
        private Stack<TreeNode> stack;

        public BSTIterator(TreeNode root)
        {
            stack = new Stack<TreeNode>();
            if (root == null)
            {
                return;
            }

            stack.Push(root);
            while (root.left != null)
            {
                stack.Push(root.left);
                root = root.left;
            }
        }

        /** @return the next smallest number */
        public int Next()
        {
            TreeNode top = stack.Pop();
            TreeNode next = top.right;
            while (next != null)
            {
                stack.Push(next);
                next = next.left;
            }

            return top.val;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            return stack.Count != 0;
        }
    }
}
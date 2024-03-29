﻿using System.Collections.Generic;
using System.Linq;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 二叉树的后序遍历
/// https://leetcode-cn.com/problems/binary-tree-postorder-traversal/
public class P0145_BinaryTreePostorderTraversal
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        IList<int> ans = new List<int>();
        if (root == null) return ans;
        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count != 0)
        {
            var top = stack.Pop();
            ans.Add(top.val);

            if (top.left != null) stack.Push(top.left);

            if (top.right != null) stack.Push(top.right);
        }

        ans = ans.Reverse().ToList();
        return ans;
    }

    public IList<int> PostorderTraversal1(TreeNode root)
    {
        IList<int> ans = new List<int>();
        if (root == null) return ans;
        var stack = new Stack<TreeNode>();
        TreeNode pre = null;
        var cur = root;
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
    private readonly IList<int> ans = new List<int>();

    public IList<int> PostorderTraversal(TreeNode root)
    {
        Traversal(root);
        return ans;
    }

    public void Traversal(TreeNode node)
    {
        if (node == null) return;
        Traversal(node.left);
        Traversal(node.right);
        ans.Add(node.val);
    }
}
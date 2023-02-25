using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 二叉树的中序遍历
/// https://leetcode-cn.com/problems/binary-tree-inorder-traversal/
public class P0094_BinaryTreeInorderTraversal
{
    private readonly IList<int> ans = new List<int>();

    public IList<int> InorderTraversal(TreeNode root)
    {
        DFS(root);
        return ans;
    }

    private void DFS(TreeNode node)
    {
        if (node == null) return;
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
        if (root == null) return ans;
        var stack = new Stack<TreeNode>();
        var cur = root;
        while (cur != null || stack.Count != 0)
            if (cur != null)
            {
                stack.Push(cur);
                cur = cur.left;
            }
            else
            {
                cur = stack.Pop();
                ans.Add(cur.val);
                cur = cur.right;
            }

        return ans;
    }
}
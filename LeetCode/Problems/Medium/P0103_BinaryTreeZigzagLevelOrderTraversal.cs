using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 二叉树的锯齿形层次遍历
/// https://leetcode-cn.com/problems/binary-tree-zigzag-level-order-traversal/
public class P0103_BinaryTreeZigzagLevelOrderTraversal
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        IList<IList<int>> ans = new List<IList<int>>();

        if (root == null) return ans;

        var stack1 = new Stack<TreeNode>();
        var stack2 = new Stack<TreeNode>();
        stack1.Push(root);
        while (stack1.Count != 0 || stack2.Count != 0)
        {
            var row = new List<int>();
            while (stack1.Count != 0)
            {
                var node = stack1.Pop();
                row.Add(node.val);
                if (node.left != null) stack2.Push(node.left);
                if (node.right != null) stack2.Push(node.right);
            }

            if (row.Count > 0) ans.Add(row);
            var row2 = new List<int>();
            while (stack2.Count != 0)
            {
                var node = stack2.Pop();
                row2.Add(node.val);
                if (node.right != null) stack1.Push(node.right);
                if (node.left != null) stack1.Push(node.left);
            }

            if (row2.Count > 0) ans.Add(row2);
        }

        return ans;
    }
}
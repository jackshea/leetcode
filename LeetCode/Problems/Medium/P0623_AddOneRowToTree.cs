using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 在二叉树中增加一行
/// https://leetcode-cn.com/problems/add-one-row-to-tree/
public class P0623_AddOneRowToTree
{
    public TreeNode AddOneRow(TreeNode root, int v, int d)
    {
        if (d == 1)
        {
            var newRoot = new TreeNode(v);
            newRoot.left = root;
            return newRoot;
        }

        var dd = 1;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (dd < d - 1)
        {
            var cnt = q.Count;
            for (var i = 0; i < cnt; i++)
            {
                var top = q.Dequeue();
                if (top.left != null) q.Enqueue(top.left);

                if (top.right != null) q.Enqueue(top.right);
            }

            dd++;
        }

        while (q.Count > 0)
        {
            var top = q.Dequeue();
            var node = new TreeNode(v);
            if (top.left != null) node.left = top.left;
            top.left = node;

            node = new TreeNode(v);
            if (top.right != null) node.right = top.right;
            top.right = node;
        }

        return root;
    }
}

public class P0623_AddOneRowToTree1
{
    public TreeNode AddOneRow(TreeNode root, int v, int d)
    {
        if (d == 0 || d == 1)
        {
            var t = new TreeNode(v);
            if (d == 1) t.left = root;
            else t.right = root;
            return t;
        }

        if (root != null && d > 1)
        {
            root.left = AddOneRow(root.left, v, d > 2 ? d - 1 : 1);
            root.right = AddOneRow(root.right, v, d > 2 ? d - 1 : 0);
        }

        return root;
    }
}
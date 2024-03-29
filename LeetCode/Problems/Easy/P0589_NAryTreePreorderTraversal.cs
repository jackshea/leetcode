﻿using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// N叉树的前序遍历
/// https://leetcode-cn.com/problems/n-ary-tree-preorder-traversal/
public class P0589_NAryTreePreorderTraversal
{
    private readonly List<int> result = new();

    public IList<int> Preorder(Node root)
    {
        if (root == null) return result;

        result.Add(root.val);
        foreach (var node in root.children) Preorder(node);

        return result;
    }

    public class Node
    {
        public IList<Node> children;
        public int val;

        public Node()
        {
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
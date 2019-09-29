using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// N叉树的最大深度
    /// https://leetcode-cn.com/problems/maximum-depth-of-n-ary-tree/
    public class P0559_MaximumDepthOfNAryTree
    {
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int maxDepth = 1;
            foreach (var child in root.children)
            {
                maxDepth = Math.Max(maxDepth, 1 + MaxDepth(child));
            }

            return maxDepth;
        }

        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }
            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }
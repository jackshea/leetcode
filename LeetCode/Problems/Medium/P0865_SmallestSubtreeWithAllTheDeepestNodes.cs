using System;
using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 具有所有最深节点的最小子树
    /// https://leetcode-cn.com/problems/smallest-subtree-with-all-the-deepest-nodes/
    public class P0865_SmallestSubtreeWithAllTheDeepestNodes
    {
        private int maxDepth = 0;
        private Dictionary<TreeNode, int> treeMaxDepth = new Dictionary<TreeNode, int>();
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            CalcMaxDepth(root, 0);
            return FindMaxDepthSubtree(root);
        }

        private int CalcMaxDepth(TreeNode node, int depth)
        {
            if (node == null)
            {
                return depth - 1;
            }

            var left = CalcMaxDepth(node.left, depth + 1);
            var right = CalcMaxDepth(node.right, depth + 1);
            depth = Math.Max(left, right);
            treeMaxDepth[node] = depth;
            maxDepth = Math.Max(maxDepth, depth);
            return depth;
        }

        private TreeNode FindMaxDepthSubtree(TreeNode node)
        {
            if (node == null || treeMaxDepth[node] != maxDepth)
            {
                return null;
            }

            if (node.left == null && node.right == null)
            {
                return node;
            }

            if (node.left != null && treeMaxDepth[node.left] == maxDepth && node.right != null && treeMaxDepth[node.right] == maxDepth)
            {
                return node;
            }

            if (node.left != null && treeMaxDepth[node.left] == maxDepth)
            {
                return FindMaxDepthSubtree(node.left);
            }

            if (node.right != null && treeMaxDepth[node.right] == maxDepth)
            {
                return FindMaxDepthSubtree(node.right);
            }

            return null;
        }
    }
}
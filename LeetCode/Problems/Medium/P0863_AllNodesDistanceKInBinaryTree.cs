using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 二叉树中所有距离为 K 的结点
    /// https://leetcode-cn.com/problems/all-nodes-distance-k-in-binary-tree/
    public class P0863_AllNodesDistanceKInBinaryTree
    {
        private Dictionary<TreeNode, TreeNode> parent = new Dictionary<TreeNode, TreeNode>();
        private HashSet<TreeNode> visited = new HashSet<TreeNode>();
        private IList<int> ans = new List<int>();
        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            BuildParent(root);
            DFS(target, 0, k);
            return ans;
        }

        private void BuildParent(TreeNode node)
        {
            if (node.left != null)
            {
                parent[node.left] = node;
                BuildParent(node.left);
            }

            if (node.right != null)
            {
                parent[node.right] = node;
                BuildParent(node.right);
            }
        }

        private void DFS(TreeNode node, int depth, int k)
        {
            if (node == null || visited.Contains(node))
            {
                return;
            }

            if (depth == k)
            {
                ans.Add(node.val);
                return;
            }

            visited.Add(node);
            DFS(node.left, depth + 1, k);
            DFS(node.right, depth + 1, k);
            if (parent.TryGetValue(node, out var p))
            {
                DFS(p, depth + 1, k);
            }
        }
    }
}
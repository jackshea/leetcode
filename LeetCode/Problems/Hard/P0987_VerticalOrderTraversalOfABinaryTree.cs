using LeetCode.Common;
using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// 二叉树的垂序遍历
    /// https://leetcode-cn.com/problems/vertical-order-traversal-of-a-binary-tree/
    public class P0987_VerticalOrderTraversalOfABinaryTree
    {
        private List<Tuple<int, int, int>> nodes = new List<Tuple<int, int, int>>();
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            DFS(root, 0, 0);
            nodes.Sort((a, b) =>
            {
                if (a.Item1 != b.Item1)
                {
                    return a.Item1.CompareTo(b.Item1);
                }

                if (a.Item2 != b.Item2)
                {
                    return a.Item2.CompareTo(b.Item2);
                }

                return a.Item3.CompareTo(b.Item3);
            });
            IList<IList<int>> ans = new List<IList<int>>();
            int size = 0;
            int lastcol = int.MinValue;
            foreach (Tuple<int, int, int> tuple in nodes)
            {
                if (tuple.Item1 != lastcol)
                {
                    lastcol = tuple.Item1;
                    ans.Add(new List<int>());
                    size++;
                }
                ans[size - 1].Add(tuple.Item3);
            }
            return ans;
        }

        void DFS(TreeNode node, int row, int col)
        {
            if (node == null)
            {
                return;
            }
            nodes.Add(new Tuple<int, int, int>(col, row, node.val));
            DFS(node.left, row + 1, col - 1);
            DFS(node.right, row + 1, col + 1);
        }
    }
}
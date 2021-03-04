using System;
using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 输出二叉树
    /// https://leetcode-cn.com/problems/print-binary-tree/
    public class P0655_PrintBinaryTree
    {
        private IList<IList<string>> ans = new List<IList<string>>();

        public IList<IList<string>> PrintTree(TreeNode root)
        {
            var rowCount = MaxDepth(root);
            var columnCount = MaxLength(rowCount);
            for (int i = 0; i < rowCount; i++)
            {
                ans.Add(new List<string>(columnCount));
                for (int j = 0; j < columnCount; j++)
                {
                    ans[i].Add("");
                }
            }
            DFS(root, 0, columnCount - 1, 0);
            return ans;
        }

        private int MaxDepth(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return Math.Max(MaxDepth(node.left), MaxDepth(node.right)) + 1;
        }

        private int MaxLength(int depth)
        {
            if (depth <= 1)
            {
                return 1;
            }

            return MaxLength(depth - 1) * 2 + 1;
        }

        private void DFS(TreeNode node, int left, int right, int depth)
        {
            if (node == null)
            {
                return;
            }

            if (left > right)
            {
                return;
            }

            int mid = (left + right) / 2;
            ans[depth][mid] = node.val.ToString();
            DFS(node.left, left, mid - 1, depth + 1);
            DFS(node.right, mid + 1, right, depth + 1);
        }
    }
}
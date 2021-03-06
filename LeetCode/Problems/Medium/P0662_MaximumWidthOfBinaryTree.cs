using System;
using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 二叉树最大宽度
    /// https://leetcode-cn.com/problems/maximum-width-of-binary-tree/
    public class P0662_MaximumWidthOfBinaryTree
    {
        Dictionary<TreeNode, int> indexes = new Dictionary<TreeNode, int>();
        public int WidthOfBinaryTree(TreeNode root)
        {
            int ans = 1;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            indexes.Add(root, 0);
            while (q.Count != 0)
            {
                int count = q.Count;
                int left = 0;
                for (int i = 0; i < count; i++)
                {
                    var top = q.Dequeue();
                    int index = indexes[top];
                    if (i == 0)
                    {
                        left = index;
                    }
                    else if (i == count - 1)
                    {
                        ans = Math.Max(ans, index - left + 1);
                    }
                    if (top.left != null)
                    {
                        q.Enqueue(top.left);
                        indexes.Add(top.left, index * 2);
                    }

                    if (top.right != null)
                    {
                        q.Enqueue(top.right);
                        indexes.Add(top.right, index * 2 + 1);
                    }
                }
            }

            return ans;
        }
    }
}
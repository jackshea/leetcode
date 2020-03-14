using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 二叉树的层次遍历
    /// https://leetcode-cn.com/problems/binary-tree-level-order-traversal/
    public class P0102_BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            if (root == null)
            {
                return ans;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                int qLen = q.Count;
                var line = new List<int>();
                for (int i = 0; i < qLen; i++)
                {
                    var top = q.Dequeue();
                    line.Add(top.val);
                    if (top.left != null)
                    {
                        q.Enqueue(top.left);
                    }
                    if (top.right != null)
                    {
                        q.Enqueue(top.right);
                    }
                }
                ans.Add(line);
            }

            return ans;
        }
    }
}
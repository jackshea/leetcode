using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 二叉树的右视图
    /// https://leetcode-cn.com/problems/binary-tree-right-side-view/
    public class P0199_BinaryTreeRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> ans = new List<int>();
            if (root == null)
            {
                return ans;
            }

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count != 0)
            {
                int n = q.Count;
                for (int i = 0; i < n; i++)
                {
                    var top = q.Dequeue();
                    if (i == n - 1)
                    {
                        ans.Add(top.val);
                    }

                    if (top.left != null)
                    {
                        q.Enqueue(top.left);
                    }

                    if (top.right != null)
                    {
                        q.Enqueue(top.right);
                    }
                }
            }

            return ans;
        }
    }
}
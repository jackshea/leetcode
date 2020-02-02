using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 二叉树的所有路径
    /// https://leetcode-cn.com/problems/binary-tree-paths/submissions/
    public class P0257_BinaryTreePaths
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            result = new List<string>();
            if (root != null)
                travel("", root);
            return result;
        }

        IList<string> result;

        private void travel(string preNodeString, TreeNode node)
        {
            if (node.left == null && node.right == null)
            {
                result.Add(preNodeString + node.val);
            }
            else
            {
                if (node.left != null)
                {
                    travel(preNodeString + node.val + "->", node.left);
                }

                if (node.right != null)
                {
                    travel(preNodeString + node.val + "->", node.right);
                }
            }
        }
    }
}
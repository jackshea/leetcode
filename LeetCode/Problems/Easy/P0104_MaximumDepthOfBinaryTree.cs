using LeetCode.Common;
using System;

namespace LeetCode.Problems.Easy
{
    /// 二叉树的最大深度
    /// https://leetcode-cn.com/problems/maximum-depth-of-binary-tree/description/
    public class P0104_MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
}
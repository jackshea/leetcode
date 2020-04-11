using System;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 打家劫舍 III
    /// https://leetcode-cn.com/problems/house-robber-iii/
    public class P0337_HouseRobberIII
    {
        public int Rob(TreeNode root)
        {
            var dp = Dp(root);
            return Math.Max(dp[0], dp[1]);
        }

        // 返回⼀个⼤⼩为 2 的数组 arr
        // arr[0] 表⽰不抢 root 的话， 得到的最⼤钱数
        // arr[1] 表⽰抢 root 的话， 得到的最⼤钱数
        private int[] Dp(TreeNode root)
        {
            if (root == null)
            {
                return new[] { 0, 0 };
            }

            var left = Dp(root.left);
            var right = Dp(root.right);

            // 选择打劫
            int rob = root.val + left[0] + right[0];
            int notRob = Math.Max(left[0], left[1]) + Math.Max(right[0], right[1]);
            return new[] { notRob, rob };
        }
    }
}
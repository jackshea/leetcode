using System;

namespace LeetCode.Problems.Medium
{
    /// 打家劫舍 II
    /// https://leetcode-cn.com/problems/house-robber-ii/
    public class P0213_HouseRobberII
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }

            return Math.Max(Rob1(nums, 0, nums.Length - 2), Rob1(nums, 1, nums.Length - 1));
        }

        // 参考打家劫舍1 无环的情况, 闭区间
        public int Rob1(int[] nums, int start, int end)
        {
            int dp0 = 0;// 前一个没选的最大值
            int dp1 = nums[start];// 前一个选了的最大值

            for (int i = start + 1; i <= end && i < nums.Length; i++)
            {
                int newDp0 = Math.Max(dp0, dp1);
                dp1 = dp0 + nums[i];
                dp0 = newDp0;
            }

            return Math.Max(dp0, dp1);
        }
    }
}
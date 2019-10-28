using System;

namespace LeetCode
{
    /// 子数组最大平均数 I
    /// https://leetcode-cn.com/problems/maximum-average-subarray-i/
    public class P0643_MaximumAverageSubarrayI
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            double maxSum = sum;

            for (int i = k; i < nums.Length; i++)
            {
                sum += -nums[i - k] + nums[i];
                maxSum = Math.Max(maxSum, sum);
            }

            return maxSum / k;
        }
    }
}
using System;

namespace LeetCode.Problems.Easy;

/// 子数组最大平均数 I
/// https://leetcode-cn.com/problems/maximum-average-subarray-i/
public class P0643_MaximumAverageSubarrayI
{
    public double FindMaxAverage(int[] nums, int k)
    {
        var sum = 0;
        for (var i = 0; i < k; i++) sum += nums[i];

        double maxSum = sum;

        for (var i = k; i < nums.Length; i++)
        {
            sum += -nums[i - k] + nums[i];
            maxSum = Math.Max(maxSum, sum);
        }

        return maxSum / k;
    }
}
using System;

namespace LeetCode.Problems.Medium;

/// 环形子数组的最大和
/// https://leetcode-cn.com/problems/maximum-sum-circular-subarray/
public class P0918_MaximumSumCircularSubarray
{
    public int MaxSubarraySumCircular(int[] nums)
    {
        int curMax, max, curMin, min, sum;
        curMax = max = curMin = min = sum = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            sum += nums[i];
            curMax = curMax > 0 ? curMax + nums[i] : nums[i];
            max = Math.Max(max, curMax);
            curMin = curMin < 0 ? curMin + nums[i] : nums[i];
            min = Math.Min(min, curMin);
        }

        if (max < 0) return max;

        return Math.Max(sum - min, max);
    }
}
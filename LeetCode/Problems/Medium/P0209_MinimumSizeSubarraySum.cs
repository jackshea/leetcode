﻿using System;

namespace LeetCode.Problems.Medium;

/// 长度最小的子数组
/// https://leetcode-cn.com/problems/minimum-size-subarray-sum/
public class P0209_MinimumSizeSubarraySum
{
    public int MinSubArrayLen(int s, int[] nums)
    {
        var left = 0;
        var right = 0;
        var sum = 0;
        var ans = int.MaxValue;
        while (right < nums.Length)
        {
            while (sum < s && right < nums.Length) sum += nums[right++];

            while (sum >= s && left < nums.Length)
            {
                ans = Math.Min(ans, right - left);
                sum -= nums[left++];
            }
        }

        if (ans == int.MaxValue) return 0;
        return ans;
    }
}
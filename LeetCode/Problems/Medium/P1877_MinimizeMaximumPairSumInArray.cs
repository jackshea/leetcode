using System;

namespace LeetCode.Problems.Medium;

/// 数组中最大数对和的最小值
/// https://leetcode-cn.com/problems/minimize-maximum-pair-sum-in-array/
public class P1877_MinimizeMaximumPairSumInArray
{
    public int MinPairSum(int[] nums)
    {
        Array.Sort(nums);
        int left = 0, right = nums.Length - 1, max = 0;
        while (left < right) max = Math.Max(max, nums[left++] + nums[right--]);

        return max;
    }
}
﻿using System;

namespace LeetCode.Problems.Easy;

/// 最长连续递增序列
/// https://leetcode-cn.com/problems/longest-continuous-increasing-subsequence/
public class P0674_LongestContinuousIncreasingSubsequence
{
    public int FindLengthOfLCIS(int[] nums)
    {
        if (nums.Length < 2) return nums.Length;

        var result = 1;
        var curSubsLength = 1;
        for (var i = 0; i < nums.Length - 1; i++)
            if (nums[i] < nums[i + 1])
            {
                curSubsLength++;
                result = Math.Max(result, curSubsLength);
            }
            else
            {
                curSubsLength = 1;
            }

        return result;
    }
}
﻿using System;

namespace LeetCode.Problems.Medium;

/// 摆动序列
/// https://leetcode-cn.com/problems/wiggle-subsequence/
public class P0376_WiggleSubsequence
{
    public int WiggleMaxLength(int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;

        int up = 1, down = 1;
        for (var i = 1; i < nums.Length; i++)
            if (nums[i] < nums[i - 1])
                down = up + 1;
            else if (nums[i] > nums[i - 1]) up = down + 1;

        return Math.Max(down, up);
    }
}
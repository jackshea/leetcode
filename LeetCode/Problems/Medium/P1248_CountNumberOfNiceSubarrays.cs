﻿using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 统计「优美子数组」
/// https://leetcode-cn.com/problems/count-number-of-nice-subarrays/
public class P1248_CountNumberOfNiceSubarrays
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        var odds = new List<int>();
        odds.Add(-1);
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] % 2 != 0)
                odds.Add(i);
        odds.Add(nums.Length);

        var ans = 0;
        for (var i = 1; i + k < odds.Count; i++) ans += (odds[i] - odds[i - 1]) * (odds[i + k] - odds[i + k - 1]);

        return ans;
    }
}
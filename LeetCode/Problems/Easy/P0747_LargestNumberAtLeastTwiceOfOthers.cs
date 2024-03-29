﻿namespace LeetCode.Problems.Easy;

/// 至少是其他数字两倍的最大数
/// https://leetcode-cn.com/problems/largest-number-at-least-twice-of-others/
public class P0747_LargestNumberAtLeastTwiceOfOthers
{
    public int DominantIndex(int[] nums)
    {
        var top1 = 0;
        var top2 = 0;
        var ans = 0;
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] >= top1)
            {
                top2 = top1;
                top1 = nums[i];
                ans = i;
            }
            else if (nums[i] > top2)
            {
                top2 = nums[i];
            }

        if (top1 >= top2 * 2) return ans;

        return -1;
    }
}
using System;

namespace LeetCode.Problems.Hard;

/// 接雨水
/// https://leetcode-cn.com/problems/trapping-rain-water/
public class P0042_TrappingRainWater
{
    public int Trap(int[] height)
    {
        var leftHightest = new int[height.Length]; // 左边最高的高度
        var rightHightest = new int[height.Length]; // 右边最高的高度
        var hightest = 0;
        for (var i = 0; i < height.Length; i++)
        {
            leftHightest[i] = hightest;
            if (hightest < height[i]) hightest = height[i];
        }

        hightest = 0;
        for (var i = height.Length - 1; i >= 0; i--)
        {
            rightHightest[i] = hightest;
            if (hightest < height[i]) hightest = height[i];
        }

        var ans = 0;
        for (var i = 0; i < height.Length - 1; i++)
        {
            var water = Math.Min(leftHightest[i], rightHightest[i]) - height[i];
            ans += water > 0 ? water : 0;
        }

        return ans;
    }
}
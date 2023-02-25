using System;

namespace LeetCode.Problems.Medium;

/// 盛最多水的容器
/// https://leetcode-cn.com/problems/container-with-most-water/
public class P0011_ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        var maxArea = 0;
        var left = 0;
        var right = height.Length - 1;
        while (left < right)
        {
            maxArea = Math.Max(maxArea, (right - left) * Math.Min(height[left], height[right]));
            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxArea;
    }
}
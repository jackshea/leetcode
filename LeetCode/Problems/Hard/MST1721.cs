using System;

namespace LeetCode.Problems.Hard;

/// 面试题 17.21. 直方图的水量
/// https://leetcode-cn.com/problems/volume-of-histogram-lcci/
public class MST1721
{
    public int Trap(int[] height)
    {
        if (height.Length <= 2) return 0;
        var left = new int[height.Length]; // 向左看最高的高度
        var right = new int[height.Length]; // 向右看最高的高度
        var max = 0;
        for (var i = 0; i < height.Length; i++)
        {
            left[i] = max;
            max = Math.Max(max, height[i]);
        }

        max = 0;
        for (var i = height.Length - 1; i >= 0; i--)
        {
            right[i] = max;
            max = Math.Max(max, height[i]);
        }

        var ans = 0;
        for (var i = 0; i < height.Length; i++)
        {
            var minHeight = Math.Min(left[i], right[i]);
            var water = minHeight - height[i];
            if (water < 0) water = 0;

            ans += water;
        }

        return ans;
    }
}

// 优化空间
public class MST1721_1
{
    public int Trap(int[] height)
    {
        if (height.Length <= 2) return 0;

        var leftMaxHeight = 0; // 左边最高高度
        var rightMaxHeight = 0; // 右边最高高度
        int left = 0, right = height.Length - 1, ans = 0;
        while (left <= right)
            if (leftMaxHeight <= rightMaxHeight)
            {
                ans += Math.Max(0, leftMaxHeight - height[left]);
                leftMaxHeight = Math.Max(leftMaxHeight, height[left]);
                left++;
            }
            else
            {
                ans += Math.Max(0, rightMaxHeight - height[right]);
                rightMaxHeight = Math.Max(rightMaxHeight, height[right]);
                right--;
            }

        return ans;
    }
}
using System;

namespace LeetCode.Problems.Medium;

/// 减小和重新排列数组后的最大元素
/// https://leetcode-cn.com/problems/maximum-element-after-decreasing-and-rearranging/
public class P1846_MaximumElementAfterDecreasingAndRearranging
{
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        Array.Sort(arr);
        var max = 0;
        foreach (var num in arr) max = Math.Min(num, max + 1);

        return max;
    }
}
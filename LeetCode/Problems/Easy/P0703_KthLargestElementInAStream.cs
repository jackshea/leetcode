﻿using System;

namespace LeetCode.Problems.Easy;

/// 数据流中的第K大元素
/// https://leetcode-cn.com/problems/kth-largest-element-in-a-stream/
public class KthLargest
{
    private readonly int[] topKp1; // 最大的K+1个元素

    public KthLargest(int k, int[] nums)
    {
        topKp1 = new int[k + 1];
        Array.Sort(nums, (a, b) => -a.CompareTo(b));
        for (var i = 0; i < topKp1.Length; i++)
            if (i < nums.Length)
                topKp1[i] = nums[i];
            else
                topKp1[i] = int.MinValue;
    }

    public int Add(int val)
    {
        for (var i = topKp1.Length - 2; i >= 0; i--)
            if (val > topKp1[i])
            {
                topKp1[i + 1] = topKp1[i];
                topKp1[i] = val;
            }
            else
            {
                break;
            }

        return topKp1[topKp1.Length - 2];
    }
}
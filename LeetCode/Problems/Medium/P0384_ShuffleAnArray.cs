﻿using System;

namespace LeetCode.Problems.Medium.P0384;

/// 打乱数组
/// https://leetcode-cn.com/problems/shuffle-an-array/
public class Solution
{
    private readonly int[] raw;

    public Solution(int[] nums)
    {
        raw = nums;
    }

    /**
     * Resets the array to its original configuration and return it.
     */
    public int[] Reset()
    {
        return raw;
    }

    /**
     * Returns a random shuffling of the array.
     */
    public int[] Shuffle()
    {
        var shuffle = new int[raw.Length];
        Array.Copy(raw, shuffle, raw.Length);
        var random = new Random((int)DateTime.Now.Ticks);
        for (var i = shuffle.Length - 1; i >= 0; i--)
        {
            var select = random.Next(i + 1);
            var temp = shuffle[select];
            shuffle[select] = shuffle[i];
            shuffle[i] = temp;
        }

        return shuffle;
    }
}
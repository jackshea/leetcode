using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 按照频率将数组升序排序
/// https://leetcode-cn.com/contest/biweekly-contest-38/problems/sort-array-by-increasing-frequency/
public class P5539
{
    public int[] FrequencySort(int[] nums)
    {
        var freq = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            freq.TryGetValue(num, out var cnt);
            freq[num] = cnt + 1;
        }

        Array.Sort(nums, (a, b) =>
        {
            if (freq[a] == freq[b]) return -a.CompareTo(b);

            return freq[a].CompareTo(freq[b]);
        });

        return nums;
    }
}
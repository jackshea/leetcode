using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 最长的斐波那契子序列的长度
/// https://leetcode-cn.com/problems/length-of-longest-fibonacci-subsequence/
public class P0873_LengthOfLongestFibonacciSubsequence
{
    public int LenLongestFibSubseq(int[] arr)
    {
        var n = arr.Length;
        var index = new Dictionary<int, int>();
        for (var i = 0; i < n; i++) index[arr[i]] = i;

        var longest = new Dictionary<int, int>();
        var ans = 0;
        for (var i = 0; i < n; i++)
        for (var j = 0; j < i; j++)
            if (index.TryGetValue(arr[i] - arr[j], out var idx) && idx < j)
            {
                var cand = 3;
                if (longest.TryGetValue(idx * n + j, out var last)) cand = last + 1;

                longest[j * n + i] = cand;
                ans = Math.Max(ans, cand);
            }

        return ans >= 3 ? ans : 0;
    }
}
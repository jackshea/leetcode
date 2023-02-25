using System;

namespace LeetCode.Problems.Medium;

/// H 指数
/// https://leetcode-cn.com/problems/h-index/
public class P0274_HIndex
{
    public int HIndex(int[] citations)
    {
        if (citations == null || citations.Length == 0) return 0;
        Array.Sort(citations, (a, b) => -a.CompareTo(b));
        var ans = -1;
        for (var i = 0; i < citations.Length; i++)
            if (citations[i] > i)
                ans = i;

        return ans + 1;
    }
}
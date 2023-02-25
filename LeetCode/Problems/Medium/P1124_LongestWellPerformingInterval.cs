using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 表现良好的最长时间段
/// https://leetcode.cn/problems/longest-well-performing-interval/
public class P1124_LongestWellPerformingInterval
{
    public int LongestWPI(int[] hours)
    {
        var n = hours.Length;
        IDictionary<int, int> dictionary = new Dictionary<int, int>();
        int s = 0, res = 0;
        for (var i = 0; i < n; i++)
        {
            s += hours[i] > 8 ? 1 : -1;
            if (s > 0)
            {
                res = Math.Max(res, i + 1);
            }
            else
            {
                if (dictionary.ContainsKey(s - 1)) res = Math.Max(res, i - dictionary[s - 1]);
            }

            if (!dictionary.ContainsKey(s)) dictionary.Add(s, i);
        }

        return res;
    }
}
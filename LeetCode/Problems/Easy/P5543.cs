using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 两个相同字符之间的最长子字符串
/// https://leetcode-cn.com/contest/weekly-contest-211/problems/largest-substring-between-two-equal-characters/
public class P5543
{
    public int MaxLengthBetweenEqualCharacters(string s)
    {
        var start = new Dictionary<char, int>();
        var end = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (!start.ContainsKey(c))
                start[c] = i;
            else
                end[c] = i;
        }

        var ans = -1;
        foreach (var c in start.Keys)
        {
            if (!end.ContainsKey(c)) continue;
            var len = end[c] - start[c] - 1;
            ans = Math.Max(ans, len);
        }

        return ans;
    }
}
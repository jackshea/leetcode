using System;

namespace LeetCode.Problems.Easy;

/// 连续字符
/// https://leetcode-cn.com/problems/consecutive-characters/
public class P1446_ConsecutiveCharacters
{
    public int MaxPower(string s)
    {
        var ans = 1;
        var count = 1;
        for (var i = 0; i < s.Length - 1; i++)
            if (s[i] == s[i + 1])
            {
                count++;
                ans = Math.Max(ans, count);
            }
            else
            {
                count = 1;
            }

        return ans;
    }
}
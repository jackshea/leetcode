using System;

namespace LeetCode.Problems.Easy;

/// 计数二进制子串
/// https://leetcode-cn.com/problems/count-binary-substrings/
public class P0696_CountBinarySubstrings
{
    public int CountBinarySubstrings(string s)
    {
        int ans = 0, prev = 0, cur = 1;
        for (var i = 1; i < s.Length; i++)
            if (s[i - 1] != s[i])
            {
                ans += Math.Min(prev, cur);
                prev = cur;
                cur = 1;
            }
            else
            {
                cur++;
            }

        return ans + Math.Min(prev, cur);
    }
}
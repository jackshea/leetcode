using System;

namespace LeetCode.Problems.Medium;

/// 尽可能使字符串相等
/// https://leetcode-cn.com/problems/get-equal-substrings-within-budget/
public class P1208_GetEqualSubstringsWithinBudget
{
    public int EqualSubstring(string s, string t, int maxCost)
    {
        var diff = new int[s.Length];
        for (var i = 0; i < s.Length; i++) diff[i] = Math.Abs(s[i] - t[i]);

        int left = 0, right = 0, sum = 0, ans = 0;
        while (right < s.Length)
        {
            sum += diff[right];
            while (sum > maxCost) sum -= diff[left++];
            ans = Math.Max(ans, right - left + 1);
            right++;
        }

        return ans;
    }
}
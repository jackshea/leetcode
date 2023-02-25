using System;

namespace LeetCode.Problems.Medium;

/// 重构字符串
/// https://leetcode-cn.com/problems/reorganize-string/
public class P0767_ReorganizeString
{
    public string ReorganizeString(string S)
    {
        if (S.Length <= 1) return S;

        var count = new int[26];
        var maxCount = 0;
        foreach (var c in S)
        {
            count[c - 'a']++;
            maxCount = Math.Max(maxCount, count[c - 'a']);
        }

        if (maxCount > (S.Length + 1) / 2) return string.Empty;

        int evenIndex = 0, oddIndex = 1;
        var ans = new char[S.Length];
        for (var i = 0; i < 26; i++)
        {
            var c = (char)('a' + i);
            while (count[i] > 0 && count[i] <= S.Length / 2 && oddIndex < S.Length)
            {
                ans[oddIndex] = c;
                count[i]--;
                oddIndex += 2;
            }

            while (count[i] > 0)
            {
                ans[evenIndex] = c;
                count[i]--;
                evenIndex += 2;
            }
        }

        return new string(ans);
    }
}
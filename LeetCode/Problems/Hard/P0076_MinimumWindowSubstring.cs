using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// 最小覆盖子串
/// https://leetcode-cn.com/problems/minimum-window-substring/
public class P0076_MinimumWindowSubstring
{
    public string MinWindow(string s, string t)
    {
        if (s.Length < t.Length) return string.Empty;

        if (s == t) return s;

        var tChars = new Dictionary<char, int>();
        foreach (var c in t)
        {
            if (!tChars.ContainsKey(c)) tChars.Add(c, 0);

            tChars[c]++;
        }

        var window = new Dictionary<char, int>();
        var minLen = int.MaxValue;
        var winLeft = 0;
        var winRight = 0;
        var left = 0;
        var right = 0;

        while (winRight < s.Length)
        {
            if (!window.ContainsKey(s[winRight])) window[s[winRight]] = 0;

            window[s[winRight]]++;

            while (IsValid(window, tChars))
            {
                var length = winRight - winLeft + 1;
                if (length < minLen)
                {
                    minLen = length;
                    left = winLeft;
                    right = winRight;
                }

                window[s[winLeft]]--;
                winLeft++;
            }

            winRight++;
        }

        if (minLen == int.MaxValue) return string.Empty;
        return s.Substring(left, right - left + 1);
    }

    private bool IsValid(Dictionary<char, int> sChars, Dictionary<char, int> tChars)
    {
        foreach (var key in tChars.Keys)
        {
            if (!sChars.ContainsKey(key)) return false;

            if (tChars[key] > sChars[key]) return false;
        }

        return true;
    }
}
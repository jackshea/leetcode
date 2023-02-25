using System;

namespace LeetCode.Problems.Medium;

/// 最长回文子串
/// https://leetcode-cn.com/problems/longest-palindromic-substring/
public class P0005_LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";
        var chars = s.ToCharArray();
        int start = 0, maxLenth = 0;
        for (var i = 0; i < chars.Length; i++)
        {
            var len1 = Expand(chars, i);
            var len2 = Expand2(chars, i);
            var len = Math.Max(len1, len2);
            if (len > maxLenth)
            {
                maxLenth = len;
                start = i - (len - 1) / 2;
            }
        }

        return s.Substring(start, maxLenth);
    }

    public int Expand(char[] chars, int mid)
    {
        int l = mid, r = mid;
        while (l >= 0 && r < chars.Length && chars[l] == chars[r])
        {
            l--;
            r++;
        }

        return r - l - 1;
    }

    public int Expand2(char[] chars, int mid)
    {
        int l = mid, r = mid + 1;
        while (l >= 0 && r < chars.Length && chars[l] == chars[r])
        {
            l--;
            r++;
        }

        return r - l - 1;
    }
}
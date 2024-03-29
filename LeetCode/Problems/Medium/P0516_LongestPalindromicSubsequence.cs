﻿using System;

namespace LeetCode.Problems.Medium;

/// 最长回文子序列
/// https://leetcode-cn.com/problems/longest-palindromic-subsequence/
public class P0516_LongestPalindromicSubsequence
{
    public int LongestPalindromeSubseq(string s)
    {
        if (s.Length <= 1) return s.Length;

        var n = s.Length;
        var dp = new int[n, n];
        for (var i = 0; i < n; i++) dp[i, i] = 1;
        for (var i = n - 1; i >= 0; i--)
        for (var j = i + 1; j < n; j++)
            if (s[i] == s[j])
                dp[i, j] = dp[i + 1, j - 1] + 2;
            else
                dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j - 1]);

        return dp[0, n - 1];
    }
}
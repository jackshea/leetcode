using System;

namespace LeetCode.Problems.Medium;

/// 分割回文串 II
/// https://leetcode-cn.com/problems/palindrome-partitioning-ii/
public class P0132_PalindromePartitioningII
{
    public int MinCut(string s)
    {
        var n = s.Length;
        var isPalindrome = new bool[n, n];

        for (var i = n - 1; i >= 0; i--)
        {
            isPalindrome[i, i] = true;
            for (var j = i + 1; j < n; j++)
                isPalindrome[i, j] = s[i] == s[j] && (isPalindrome[i + 1, j - 1] || j - i - 1 <= 1);
        }

        var dp = new int[n];
        Array.Fill(dp, int.MaxValue);
        for (var i = 0; i < n; i++)
            if (isPalindrome[0, i])
                dp[i] = 0;
            else
                for (var j = 0; j < i; j++)
                    if (isPalindrome[j + 1, i])
                        dp[i] = Math.Min(dp[i], dp[j] + 1);

        return dp[n - 1];
    }
}
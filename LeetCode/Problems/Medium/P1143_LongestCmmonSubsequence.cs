using System;

namespace LeetCode.Problems.Medium;

public class P1143_LongestCmmonSubsequence
{
    /// 最长公共子序列
    /// https://leetcode-cn.com/problems/longest-common-subsequence/
    // 状态转移方程：text1[i]==text2[j] 时 dp[i,j]=dp[i-1,j-1]+1
    //              text1[i]!=text2[j] 时 dp[i,j]=Max(dp[i-1,j],dp[i,j-1])
    // 时间复杂度： O(mn)
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var m = text1.Length;
        var n = text2.Length;
        var dp = new int[m + 1, n + 1];
        for (var i = 1; i <= m; i++)
        for (var j = 1; j <= n; j++)
            if (text1[i - 1] == text2[j - 1])
                dp[i, j] = dp[i - 1, j - 1] + 1;
            else
                dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);

        return dp[m, n];
    }
}
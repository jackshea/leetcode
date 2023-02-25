using System;

namespace LeetCode.Problems.Hard;

/// 编辑距离
/// https://leetcode-cn.com/problems/edit-distance/
public class P0072_EditDistance
{
    public int MinDistance(string word1, string word2)
    {
        var m = word1.Length + 1;
        var n = word2.Length + 1;
        var dp = new int[m, n];
        for (var i = 0; i < m; i++) dp[i, 0] = i;

        for (var i = 0; i < n; i++) dp[0, i] = i;

        for (var i = 1; i < m; i++)
        for (var j = 1; j < n; j++)
            if (word1[i - 1] == word2[j - 1])
                dp[i, j] = dp[i - 1, j - 1];
            else
                dp[i, j] = 1 + Math.Min(Math.Min(dp[i, j - 1], dp[i - 1, j]), dp[i - 1, j - 1]);

        return dp[m - 1, n - 1];
    }
}
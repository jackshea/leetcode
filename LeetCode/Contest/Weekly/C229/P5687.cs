using System;

namespace LeetCode.Contest.Weekly.C229;

/// 执行乘法运算的最大分数
/// https://leetcode-cn.com/contest/weekly-contest-229/problems/maximum-score-from-performing-multiplication-operations/
public class P5687
{
    public int MaximumScore(int[] nums, int[] multipliers)
    {
        var n = multipliers.Length;
        var dp = new int[n + 1, n + 1];
        for (var i = 0; i < dp.GetLength(0); i++)
        for (var j = 0; j < dp.GetLength(1); j++)
            dp[i, j] = (int)-1E9;

        dp[0, 0] = 0;
        for (var l = 0; l < n; l++)
        for (var r = 0; r + l < n; r++)
        {
            dp[l + 1, r] = Math.Max(dp[l + 1, r], dp[l, r] + nums[l] * multipliers[l + r]);
            dp[l, r + 1] = Math.Max(dp[l, r + 1], dp[l, r] + nums[nums.Length - 1 - r] * multipliers[l + r]);
        }

        var ans = (int)-1e9;
        for (var i = 0; i <= n; i++) ans = Math.Max(ans, dp[i, n - i]);

        return ans;
    }
}

public class P5687_1
{
    public int MaximumScore(int[] nums, int[] multipliers)
    {
        var n = multipliers.Length;
        var dp = new int[n + 1][];
        for (var i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[n + 1];
            Array.Fill(dp[i], int.MinValue / 2);
        }

        dp[0][0] = 0;
        for (var i = 0; i < n; i++)
        for (var j = 0; j < n - i; j++)
        {
            // dp为左边取i个,右边取j个乘积的最大值
            dp[i + 1][j] = Math.Max(dp[i + 1][j], dp[i][j] + nums[i] * multipliers[i + j]);
            dp[i][j + 1] = Math.Max(dp[i][j + 1], dp[i][j] + nums[nums.Length - 1 - j] * multipliers[i + j]);
        }

        var ans = int.MinValue / 2;
        for (var i = 0; i <= n; i++) ans = Math.Max(ans, dp[i][n - i]);

        return ans;
    }
}
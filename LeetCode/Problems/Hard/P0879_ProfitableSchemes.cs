﻿using System;

namespace LeetCode.Problems.Hard;

/// 盈利计划
/// https://leetcode-cn.com/problems/profitable-schemes/
public class P0879_ProfitableSchemes
{
    private const int MOD = (int)1E9 + 7;

    public int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit)
    {
        var len = group.Length;
        var dp = new int[len + 1, n + 1, minProfit + 1];
        dp[0, 0, 0] = 1;
        for (var i = 1; i <= len; i++)
        {
            var members = group[i - 1];
            var earn = profit[i - 1];
            for (var j = 0; j <= n; j++)
            for (var k = 0; k <= minProfit; k++)
                if (j < members)
                    dp[i, j, k] = dp[i - 1, j, k];
                else
                    dp[i, j, k] = (dp[i - 1, j, k] + dp[i - 1, j - members, Math.Max(0, k - earn)]) % MOD;
        }

        var sum = 0;
        for (var i = 0; i <= n; i++) sum = (sum + dp[len, i, minProfit]) % MOD;

        return sum;
    }
}
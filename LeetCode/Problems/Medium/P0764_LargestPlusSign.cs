using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 最大加号标志
/// https://leetcode-cn.com/problems/largest-plus-sign/
public class P0764_LargestPlusSign
{
    public int OrderOfLargestPlusSign(int N, int[][] mines)
    {
        var banned = new HashSet<int>();
        foreach (var mine in mines) banned.Add(mine[0] * N + mine[1]);
        var dp = new int[N, N];
        for (var i = 0; i < N; i++)
        for (var j = 0; j < N; j++)
            dp[i, j] = N;

        var count = 0;
        for (var i = 0; i < N; i++)
        {
            count = 0;
            for (var j = 0; j < N; j++)
            {
                count = banned.Contains(i * N + j) ? 0 : count + 1;
                dp[i, j] = Math.Min(dp[i, j], count);
            }

            count = 0;
            for (var j = 0; j < N; j++)
            {
                count = banned.Contains(j * N + i) ? 0 : count + 1;
                dp[j, i] = Math.Min(dp[j, i], count);
            }

            count = 0;
            for (var j = N - 1; j >= 0; j--)
            {
                count = banned.Contains(i * N + j) ? 0 : count + 1;
                dp[i, j] = Math.Min(dp[i, j], count);
            }

            count = 0;
            for (var j = N - 1; j >= 0; j--)
            {
                count = banned.Contains(j * N + i) ? 0 : count + 1;
                dp[j, i] = Math.Min(dp[j, i], count);
            }
        }

        var ans = 0;
        for (var i = 0; i < N; i++)
        for (var j = 0; j < N; j++)
            ans = Math.Max(ans, dp[i, j]);

        return ans;
    }
}
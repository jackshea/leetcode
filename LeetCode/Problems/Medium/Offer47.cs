using System;

namespace LeetCode.Problems.Medium;

/// 礼物的最大价值
/// https://leetcode.cn/problems/li-wu-de-zui-da-jie-zhi-lcof/
public class Offer47
{
    public int MaxValue(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int[] dp = new int[n];
        for (int i = 0; i < n; i++)
        {
            dp[i] = 0;
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j > 0)
                {
                    dp[j] = Math.Max(dp[j], dp[j - 1]) + grid[i][j];
                }
                else
                {
                    dp[j] += grid[i][j];
                }
            }
        }

        int ans = 0;
        for (int i = 0; i < n; i++)
        {
            ans = Math.Max(ans, dp[i]);
        }

        return ans;
    }
}
using System;

namespace LeetCode.Problems.Medium
{
    /// K 站中转内最便宜的航班
    /// https://leetcode-cn.com/problems/cheapest-flights-within-k-stops/
    public class P0787_CheapestFlightsWithinKStops
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K)
        {
            int[][] dp = new int[n][];
            for (int i = 0; i < n; i++)
            {
                dp[i] = new int[K + 2];
                Array.Fill(dp[i], int.MaxValue);
            }

            for (int i = 0; i <= K + 1; i++)
            {
                dp[src][i] = 0;
            }

            for (int i = 1; i <= K + 1; i++)
            {
                foreach (var f in flights)
                {
                    if (dp[f[0]][i - 1] != int.MaxValue)
                    {
                        dp[f[1]][i] = Math.Min(dp[f[1]][i], dp[f[0]][i - 1] + f[2]);
                    }
                }
            }

            int ans = dp[dst][K + 1];
            return ans == int.MaxValue ? -1 : ans;
        }
    }
}
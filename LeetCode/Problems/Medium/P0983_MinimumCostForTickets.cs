using System;

namespace LeetCode.Problems.Medium
{
    /// 最低票价
    /// https://leetcode-cn.com/problems/minimum-cost-for-tickets/
    public class P0983_MinimumCostForTickets
    {
        public int MincostTickets(int[] days, int[] costs)
        {
            int n = days[days.Length - 1];
            int[] dp = new int[n + 1];
            for (int i = 0; i < days.Length; i++)
            {
                dp[days[i]] = -1;
            }

            for (int i = 1; i < dp.Length; i++)
            {
                if (dp[i] == 0)
                {
                    dp[i] = dp[i - 1];
                }
                else
                {
                    dp[i] = dp[i - 1] + costs[0];
                    dp[i] = Math.Min(dp[i], (i >= 7 ? dp[i - 7] : 0) + costs[1]);
                    dp[i] = Math.Min(dp[i], (i >= 30 ? dp[i - 30] : 0) + costs[2]);
                }
            }

            return dp[n];
        }
    }
}
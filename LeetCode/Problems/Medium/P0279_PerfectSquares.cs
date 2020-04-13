using System;

namespace LeetCode.Problems.Medium
{
    /// 完全平方数
    /// https://leetcode-cn.com/problems/perfect-squares/
    public class P0279_PerfectSquares
    {
        public int NumSquares(int n)
        {
            int[] dp = new int[n + 1];
            for (int i = 1; i < dp.Length; i++)
            {
                dp[i] = n + 1;
            }

            dp[0] = 0;
            int[] sq = new int[(int)Math.Sqrt(n) + 1];
            for (int i = 0; i < sq.Length; i++)
            {
                sq[i] = i * i;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < sq.Length && i - sq[j] >= 0; j++)
                {
                    dp[i] = Math.Min(dp[i], dp[i - sq[j]] + 1);
                }
            }

            return dp[n];
        }
    }
}
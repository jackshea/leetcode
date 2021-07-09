using System;

namespace LeetCode.Problems.Medium
{
    /// 新21点
    /// https://leetcode-cn.com/problems/new-21-game/
    public class P0837_New21Game
    {
        public double New21Game(int n, int k, int maxPts)
        {
            if (k == 0)
            {
                return 1.0;
            }
            double[] dp = new double[k + maxPts];
            for (int i = k; i <= n && i < k + maxPts; i++)
            {
                dp[i] = 1.0;
            }
            dp[k - 1] = 1.0 * Math.Min(n - k + 1, maxPts) / maxPts;
            for (int i = k - 2; i >= 0; i--)
            {
                dp[i] = dp[i + 1] - (dp[i + maxPts + 1] - dp[i + 1]) / maxPts;
            }
            return dp[0];
        }

        public double New21Game_1(int n, int k, int maxPts)
        {
            if (k == 0)
            {
                return 1;
            }

            double[] dp = new double[k + maxPts];
            for (int i = k; i <= n && i < k + maxPts; i++)
            {
                dp[i] = 1.0;
            }
            for (int i = k - 1; i >= 0; i--)
            {
                for (int j = 1; j <= maxPts; j++)
                {
                    dp[i] += dp[i + j] / maxPts;
                }
            }
            return dp[0];
        }
    }
}
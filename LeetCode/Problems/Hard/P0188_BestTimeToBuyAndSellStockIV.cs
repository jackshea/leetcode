using System;

namespace LeetCode.Problems.Hard
{
    /// 买卖股票的最佳时机 IV
    /// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-iv/
    public class P0188_BestTimeToBuyAndSellStockIV
    {
        public int MaxProfit(int k, int[] prices)
        {
            if (k > prices.Length / 2)
            {
                k = prices.Length / 2;
            }

            int[,] dp = new int[k + 1, 2];
            for (int i = 0; i <= k; i++)
            {
                dp[i, 0] = 0;
                dp[i, 1] = int.MinValue;
            }

            foreach (var price in prices)
            {
                for (int i = 1; i <= k; i++)
                {
                    dp[i, 0] = Math.Max(dp[i, 0], dp[i, 1] + price);
                    dp[i, 1] = Math.Max(dp[i, 1], dp[i - 1, 0] - price);
                }
            }

            return dp[k, 0];
        }
    }
}
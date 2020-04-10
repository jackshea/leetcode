using System;

namespace LeetCode.Problems.Easy
{
    /// 买卖股票的最佳时机 II
    /// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-ii/description/
    public class P0122_BestTimeToBuyAndSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            int dp0 = 0;
            int dp1 = int.MinValue;
            foreach (var price in prices)
            {
                dp1 = Math.Max(dp1, dp0 - price);
                dp0 = Math.Max(dp0, dp1 + price);
            }

            return dp0;
        }
    }

    public class P0122_BestTimeToBuyAndSellStockII_1
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 0)
            {
                return 0;
            }
            int profit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                var currentProfit = prices[i] - prices[i - 1];
                if (currentProfit > 0)
                {
                    profit += currentProfit;
                }
            }

            return profit;
        }
    }
}
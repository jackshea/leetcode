using System;

namespace LeetCode.Problems.Easy
{
    /// 买卖股票的最佳时机
    /// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/description/
    public class P0121_BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 0)
            {
                return 0;
            }
            int soFarMaxProfit = 0;
            int minPrice = Int32.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                soFarMaxProfit = Math.Max(soFarMaxProfit, prices[i] - minPrice);
                minPrice = Math.Min(minPrice, prices[i]);
            }

            return soFarMaxProfit;
        }
    }
}
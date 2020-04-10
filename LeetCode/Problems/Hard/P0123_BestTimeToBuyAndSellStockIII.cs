using System;

namespace LeetCode.Problems.Hard
{
    /// 买卖股票的最佳时机 III
    /// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-iii/
    public class P0123_BestTimeToBuyAndSellStockIII
    {
        public int MaxProfit(int[] prices)
        {
            // dp后第一位： 0 代表不持有股票，1代表持有股票
            //     第二位： 最多交易次数
            int dp11 = int.MinValue;
            int dp01 = 0;
            int dp12 = int.MinValue;
            int dp02 = 0;
            foreach (var price in prices)
            {
                dp02 = Math.Max(dp02, dp12 + price);
                dp12 = Math.Max(dp12, dp01 - price);
                dp01 = Math.Max(dp01, dp11 + price);
                dp11 = Math.Max(dp11, 0 - price);
            }

            return dp02;
        }
    }
}
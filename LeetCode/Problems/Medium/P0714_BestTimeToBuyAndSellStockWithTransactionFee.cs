using System;

namespace LeetCode.Problems.Medium;

/// 买卖股票的最佳时机含手续费
/// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/
public class P0714_BestTimeToBuyAndSellStockWithTransactionFee
{
    public int MaxProfit(int[] prices, int fee)
    {
        var dp0 = 0;
        var dp1 = int.MinValue;
        foreach (var price in prices)
        {
            dp1 = Math.Max(dp1, dp0 - price);
            dp0 = Math.Max(dp0, dp1 + price - fee);
        }

        return dp0;
    }
}
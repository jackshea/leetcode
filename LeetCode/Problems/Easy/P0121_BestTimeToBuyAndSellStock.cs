using System;

namespace LeetCode.Problems.Easy;

/// 买卖股票的最佳时机
/// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/description/
public class P0121_BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var lowest = int.MaxValue;
        foreach (var price in prices)
        {
            lowest = Math.Min(lowest, price);
            maxProfit = Math.Max(maxProfit, price - lowest);
        }

        return maxProfit;
    }
}

public class P0121_BestTimeToBuyAndSellStock_1
{
    public int MaxProfit(int[] prices)
    {
        if (prices == null || prices.Length <= 0) return 0;
        var soFarMaxProfit = 0;
        var minPrice = int.MaxValue;
        for (var i = 0; i < prices.Length; i++)
        {
            soFarMaxProfit = Math.Max(soFarMaxProfit, prices[i] - minPrice);
            minPrice = Math.Min(minPrice, prices[i]);
        }

        return soFarMaxProfit;
    }
}
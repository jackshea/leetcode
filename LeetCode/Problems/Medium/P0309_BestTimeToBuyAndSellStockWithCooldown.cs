using System;

namespace LeetCode.Problems.Medium;

/// 最佳买卖股票时机含冷冻期
/// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-with-cooldown/
public class P0309_BestTimeToBuyAndSellStockWithCooldown
{
    public int MaxProfit(int[] prices)
    {
        var dp0 = 0; //  前一天不持有最大利润
        var dp00 = 0; // 前两天不持有最大利润
        var dp1 = int.MinValue; // 前一天持有最大利润
        foreach (var price in prices)
        {
            dp1 = Math.Max(dp1, dp00 - price);
            dp00 = dp0;
            dp0 = Math.Max(dp0, dp1 + price);
        }

        return dp0;
    }
}
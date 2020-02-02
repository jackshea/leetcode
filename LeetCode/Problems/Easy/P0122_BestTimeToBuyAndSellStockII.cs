namespace LeetCode.Problems.Easy
{
    /// 买卖股票的最佳时机 II
    /// https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock-ii/description/
    public class P0122_BestTimeToBuyAndSellStockII
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
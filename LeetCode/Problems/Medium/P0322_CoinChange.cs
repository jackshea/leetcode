using System;

namespace LeetCode.Problems.Medium
{
    /// 零钱兑换
    /// https://leetcode-cn.com/problems/coin-change/
    public class P0322_CoinChange
    {
        public int CoinChange(int[] coins, int amount)
        {
            // dp[m]==n 其中m为金额总数，n为最少硬币数
            // dp[m]=Min(dp[m],dp[m-coins[i]]+1)
            int[] dp = new int[amount + 1];
            for (int i = 1; i < dp.Length; i++)
            {
                dp[i] = amount + 1;
            }

            if (coins[0] == amount)
            {
                return 1;
            }

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = coins[i]; j <= amount; j++)
                {
                    dp[j] = Math.Min(dp[j], dp[j - coins[i]] + 1);
                }
            }

            return dp[amount] == amount + 1 ? -1 : dp[amount];
        }
    }
}
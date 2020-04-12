namespace LeetCode.Problems.Medium
{
    /// 零钱兑换 II
    /// https://leetcode-cn.com/problems/coin-change-2/
    public class P0518_CoinChange2
    {
        public int Change(int amount, int[] coins)
        {
            // dp[m]==n 其中m为金额总数，n为方案数
            // dp[i][m]=Sum(dp[i-1][m],dp[i][m-coins[i]])
            int[] dp = new int[amount + 1];

            dp[0] = 1;

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = coins[i]; j <= amount; j++)
                {
                    dp[j] += dp[j - coins[i]];
                }
            }

            return dp[amount];
        }
    }
}
using System;

namespace LeetCode.Problems.Hard
{
    /// 盈利计划
    /// https://leetcode-cn.com/problems/profitable-schemes/
    public class P0879_ProfitableSchemes
    {
        private const int MOD = (int)1E9 + 7;
        public int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit)
        {
            int len = group.Length;
            int[,,] dp = new int[len + 1, n + 1, minProfit + 1];
            dp[0, 0, 0] = 1;
            for (int i = 1; i <= len; i++)
            {
                int members = group[i - 1];
                int earn = profit[i - 1];
                for (int j = 0; j <= n; j++)
                {
                    for (int k = 0; k <= minProfit; k++)
                    {
                        if (j < members)
                        {
                            dp[i, j, k] = dp[i - 1, j, k];
                        }
                        else
                        {
                            dp[i, j, k] = (dp[i - 1, j, k] + dp[i - 1, j - members, Math.Max(0, k - earn)]) % MOD;
                        }
                    }
                }
            }

            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum = (sum + dp[len, i, minProfit]) % MOD;
            }

            return sum;
        }
    }
}
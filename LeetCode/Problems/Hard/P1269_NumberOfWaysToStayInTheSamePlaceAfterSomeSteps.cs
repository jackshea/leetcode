using System;

namespace LeetCode.Problems.Hard
{
    /// 停在原地的方案数
    /// https://leetcode-cn.com/problems/number-of-ways-to-stay-in-the-same-place-after-some-steps/
    public class P1269_NumberOfWaysToStayInTheSamePlaceAfterSomeSteps
    {
        private const int MOD = 1000000007;
        public int NumWays(int steps, int arrLen)
        {
            int dpLen = Math.Min(steps / 2 + 1, arrLen);
            int[] dp = new int[dpLen];
            dp[0] = 1;
            int[] preDp = new int[dpLen];
            for (int i = 1; i <= steps; i++)
            {
                int[] tmp = preDp;
                preDp = dp;
                dp = tmp;
                for (int j = 0; j < dpLen; j++)
                {
                    dp[j] = preDp[j];
                    if (j > 0)
                    {
                        dp[j] = (dp[j] + preDp[j - 1]) % MOD;
                    }
                    if (j < dpLen - 1)
                    {
                        dp[j] = (dp[j] + preDp[j + 1]) % MOD;
                    }
                }
            }

            return dp[0];
        }
    }
}
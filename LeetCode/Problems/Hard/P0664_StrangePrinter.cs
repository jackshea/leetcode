using System;

namespace LeetCode.Problems.Hard
{
    /// 奇怪的打印机
    /// https://leetcode-cn.com/problems/strange-printer/
    public class P0664_StrangePrinter
    {
        public int StrangePrinter(string s)
        {
            int n = s.Length;
            int[,] dp = new int[n, n];
            for (int i = n - 1; i >= 0; i--)
            {
                dp[i, i] = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (s[i] == s[j])
                    {
                        dp[i, j] = dp[i, j - 1];
                    }
                    else
                    {
                        int min = int.MaxValue;
                        for (int k = i; k < j; k++)
                        {
                            min = Math.Min(min, dp[i, k] + dp[k + 1, j]);
                        }

                        dp[i, j] = min;
                    }
                }
            }

            return dp[0, n - 1];
        }
    }
}
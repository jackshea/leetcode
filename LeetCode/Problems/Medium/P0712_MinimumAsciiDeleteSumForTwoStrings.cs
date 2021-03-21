using System;

namespace LeetCode.Problems.Medium
{
    /// 两个字符串的最小ASCII删除和
    /// https://leetcode-cn.com/problems/minimum-ascii-delete-sum-for-two-strings/
    public class P0712_MinimumAsciiDeleteSumForTwoStrings
    {
        public int MinimumDeleteSum(string s1, string s2)
        {
            var m = s1.Length;
            var n = s2.Length;
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 1; i <= m; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + s1[i - 1];
            }

            for (int i = 1; i <= n; i++)
            {
                dp[0, i] = dp[0, i - 1] + s2[i - 1];
            }

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s1[i - 1] == s2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j] + s1[i - 1], dp[i, j - 1] + s2[j - 1]);
                    }
                }
            }

            return dp[m, n];
        }
    }
}
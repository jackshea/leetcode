using System;

namespace LeetCode.Problems.Medium
{
    /// 一和零
    /// https://leetcode-cn.com/problems/ones-and-zeroes/
    public class P0474_OnesAndZeroes
    {
        public int FindMaxForm(string[] strs, int m, int n)
        {
            // strs每字符串中 0的数量 和 1的数量 
            int[,] bitCount = new int[strs.Length, 2];
            for (int i = 0; i < strs.Length; i++)
            {
                int zero = 0;
                int one = 0;
                foreach (var c in strs[i])
                {
                    if (c == '0')
                    {
                        zero++;
                    }
                    else if (c == '1')
                    {
                        one++;
                    }
                }

                bitCount[i, 0] = zero;
                bitCount[i, 1] = one;
            }

            int[,] dp = new int[m + 1, n + 1];
            for (int i = 0; i < strs.Length; i++)
            {
                for (int j = m; j >= bitCount[i, 0]; j--)
                {
                    for (int k = n; k >= bitCount[i, 1]; k--)
                    {
                        dp[j, k] = Math.Max(dp[j, k], dp[j - bitCount[i, 0], k - bitCount[i, 1]] + 1);
                    }
                }
            }

            return dp[m, n];
        }
    }
}
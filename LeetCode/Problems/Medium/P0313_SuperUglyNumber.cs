using System;

namespace LeetCode.Problems.Medium
{
    /// 超级丑数
    /// https://leetcode-cn.com/problems/super-ugly-number/
    public class P0313_SuperUglyNumber
    {
        public int NthSuperUglyNumber(int n, int[] primes)
        {
            int len = primes.Length;
            int[] dp = new int[n];
            dp[0] = 1;
            int[] index = new int[len];
            for (int i = 1; i < n; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < len; j++)
                {
                    var num = primes[j] * dp[index[j]];
                    min = Math.Min(min, num);
                }

                dp[i] = min;

                for (int j = 0; j < len; j++)
                {
                    if (min == primes[j] * dp[index[j]])
                    {
                        index[j]++;
                    }
                }
            }

            return dp[n - 1];
        }
    }
}
using System;

namespace LeetCode.Problems.Medium;

/// 超级丑数
/// https://leetcode-cn.com/problems/super-ugly-number/
public class P0313_SuperUglyNumber
{
    public int NthSuperUglyNumber(int n, int[] primes)
    {
        var len = primes.Length;
        var dp = new int[n];
        dp[0] = 1;
        var index = new int[len];
        for (var i = 1; i < n; i++)
        {
            var min = int.MaxValue;
            for (var j = 0; j < len; j++)
            {
                var num = primes[j] * dp[index[j]];
                min = Math.Min(min, num);
            }

            dp[i] = min;

            for (var j = 0; j < len; j++)
                if (min == primes[j] * dp[index[j]])
                    index[j]++;
        }

        return dp[n - 1];
    }
}
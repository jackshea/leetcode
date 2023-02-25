using System;

namespace LeetCode.Problems.Medium;

/// 整数拆分
/// https://leetcode-cn.com/problems/integer-break/
public class P0343_IntegerBreak
{
    public int IntegerBreak(int n)
    {
        if (n < 4) return n - 1;

        var dp = new int[n + 1]; // 和为n 的最大乘积，可以不拆分
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 3;
        for (var i = 4; i <= n; i++)
        {
            var max = i;
            for (var j = 2; j < i; j++) max = Math.Max(max, dp[j] * dp[i - j]);

            dp[i] = max;
        }

        return dp[n];
    }
}
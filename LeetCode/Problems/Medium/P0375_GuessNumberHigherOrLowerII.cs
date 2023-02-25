using System;

namespace LeetCode.Problems.Medium;

/// 猜数字大小 II
/// https://leetcode-cn.com/problems/guess-number-higher-or-lower-ii/
public class P0375_GuessNumberHigherOrLowerII
{
    private int[,] dp;

    public int GetMoneyAmount(int n)
    {
        dp = new int[n + 1, n + 1];
        for (var i = 0; i < dp.GetLength(0); i++)
        for (var j = 0; j < dp.GetLength(1); j++)
            dp[i, j] = -1;

        return calc(1, n);
    }

    private int calc(int low, int high)
    {
        if (low >= high) return 0;

        var ans = dp[low, high];
        if (ans != -1) return ans;

        ans = int.MaxValue;
        for (var i = (low + high) / 2; i <= high; i++)
        {
            var temp = i + Math.Max(calc(low, i - 1), calc(i + 1, high));
            if (temp < ans) ans = temp;
        }

        dp[low, high] = ans;
        return ans;
    }
}
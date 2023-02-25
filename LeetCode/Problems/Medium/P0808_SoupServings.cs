using System;

namespace LeetCode.Problems.Medium;

/// 分汤
/// https://leetcode-cn.com/problems/soup-servings/
public class P0808_SoupServings
{
    public double SoupServings(int n)
    {
        n = n / 25 + (n % 25 > 0 ? 1 : 0);
        if (n >= 500) return 1.0;
        var memo = new double[n + 1, n + 1];
        for (var i = 0; i <= 2 * n; i++)
        for (var j = 0; j <= n; j++)
        {
            var k = i - j;
            if (k < 0 || k > n) continue;

            double ans = 0;
            if (j == 0) ans = 1;
            if (j == 0 && k == 0) ans = 0.5;
            if (j > 0 && k > 0)
                ans = 0.25 * (memo[M(j - 4), k] + memo[M(j - 3), M(k - 1)] +
                              memo[M(j - 2), M(k - 2)] + memo[M(j - 1), M(k - 3)]);

            memo[j, k] = ans;
        }

        return memo[n, n];
    }

    public int M(int x)
    {
        return Math.Max(0, x);
    }
}
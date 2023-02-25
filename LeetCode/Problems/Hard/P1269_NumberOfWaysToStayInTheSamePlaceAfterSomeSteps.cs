using System;

namespace LeetCode.Problems.Hard;

/// 停在原地的方案数
/// https://leetcode-cn.com/problems/number-of-ways-to-stay-in-the-same-place-after-some-steps/
public class P1269_NumberOfWaysToStayInTheSamePlaceAfterSomeSteps
{
    private const int MOD = 1000000007;

    public int NumWays(int steps, int arrLen)
    {
        var dpLen = Math.Min(steps / 2 + 1, arrLen);
        var dp = new int[dpLen];
        dp[0] = 1;
        var preDp = new int[dpLen];
        for (var i = 1; i <= steps; i++)
        {
            var tmp = preDp;
            preDp = dp;
            dp = tmp;
            for (var j = 0; j < dpLen; j++)
            {
                dp[j] = preDp[j];
                if (j > 0) dp[j] = (dp[j] + preDp[j - 1]) % MOD;
                if (j < dpLen - 1) dp[j] = (dp[j] + preDp[j + 1]) % MOD;
            }
        }

        return dp[0];
    }
}
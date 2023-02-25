using System;

namespace LeetCode.Problems.Medium;

/// 一和零
/// https://leetcode-cn.com/problems/ones-and-zeroes/
public class P0474_OnesAndZeroes
{
    public int FindMaxForm(string[] strs, int m, int n)
    {
        // strs每字符串中 0的数量 和 1的数量 
        var bitCount = new int[strs.Length, 2];
        for (var i = 0; i < strs.Length; i++)
        {
            var zero = 0;
            var one = 0;
            foreach (var c in strs[i])
                if (c == '0')
                    zero++;
                else if (c == '1') one++;

            bitCount[i, 0] = zero;
            bitCount[i, 1] = one;
        }

        var dp = new int[m + 1, n + 1];
        for (var i = 0; i < strs.Length; i++)
        for (var j = m; j >= bitCount[i, 0]; j--)
        for (var k = n; k >= bitCount[i, 1]; k--)
            dp[j, k] = Math.Max(dp[j, k], dp[j - bitCount[i, 0], k - bitCount[i, 1]] + 1);

        return dp[m, n];
    }
}
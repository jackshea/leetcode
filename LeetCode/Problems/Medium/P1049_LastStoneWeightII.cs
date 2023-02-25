using System;
using System.Linq;

namespace LeetCode.Problems.Medium;

/// 最后一块石头的重量 II
/// https://leetcode-cn.com/problems/last-stone-weight-ii/
public class P1049_LastStoneWeightII
{
    public int LastStoneWeightII(int[] stones)
    {
        var sum = stones.Sum();
        var cap = sum / 2;
        var dp = new int[cap + 1];
        for (var i = 0; i < stones.Length; i++)
        for (var j = cap; j >= stones[i]; j--)
            dp[j] = Math.Max(dp[j], dp[j - stones[i]] + stones[i]);

        return sum - dp[cap] * 2;
    }
}
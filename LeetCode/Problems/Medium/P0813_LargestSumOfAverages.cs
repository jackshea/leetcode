using System;

namespace LeetCode.Problems.Medium;

/// 最大平均值和的分组
/// https://leetcode-cn.com/problems/largest-sum-of-averages/
public class P0813_LargestSumOfAverages
{
    public double LargestSumOfAverages(int[] nums, int k)
    {
        var n = nums.Length;
        var preSum = new double[n + 1];
        for (var i = 0; i < n; i++) preSum[i + 1] = preSum[i] + nums[i];

        var dp = new double[n];
        for (var i = 0; i < n; i++) dp[i] = (preSum[n] - preSum[i]) / (n - i);

        for (var i = 0; i < k - 1; i++)
        for (var j = 0; j < n; j++)
        for (var l = j + 1; l < n; l++)
            dp[j] = Math.Max(dp[j], (preSum[l] - preSum[j]) / (l - j) + dp[l]);

        return dp[0];
    }
}
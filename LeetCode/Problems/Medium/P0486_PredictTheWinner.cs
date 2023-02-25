using System;

namespace LeetCode.Problems.Medium;

/// 预测赢家
/// https://leetcode-cn.com/problems/predict-the-winner/
public class P0486_PredictTheWinner
{
    public bool PredictTheWinner(int[] nums)
    {
        var n = nums.Length;
        var dp = new int[n, n];
        for (var i = 0; i < n; i++) dp[i, i] = nums[i];

        for (var i = n - 2; i >= 0; i--)
        for (var j = i + 1; j < n; j++)
            dp[i, j] = Math.Max(nums[i] - dp[i + 1, j], nums[j] - dp[i, j - 1]);

        return dp[0, n - 1] >= 0;
    }
}
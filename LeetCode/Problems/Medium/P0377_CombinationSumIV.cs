namespace LeetCode.Problems.Medium;

/// 组合总和 Ⅳ
/// https://leetcode-cn.com/problems/combination-sum-iv/
public class P0377_CombinationSumIV
{
    public int CombinationSum4(int[] nums, int target)
    {
        var dp = new int[target + 1];
        dp[0] = 1;
        for (var i = 1; i <= target; i++)
            foreach (var num in nums)
                if (i - num >= 0)
                    dp[i] += dp[i - num];

        return dp[target];
    }
}
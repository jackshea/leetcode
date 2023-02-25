namespace LeetCode.Problems.Medium;

/// 目标和
/// https://leetcode-cn.com/problems/target-sum/
public class P0494_TargetSum
{
    public int FindTargetSumWays(int[] nums, int S)
    {
        var dp = new int[2001];
        dp[nums[0] + 1000] += 1;
        dp[-nums[0] + 1000] += 1;
        for (var i = 1; i < nums.Length; i++)
        {
            var next = new int[2001];
            for (var j = -1000; j < 1001; j++)
                if (dp[j + 1000] > 0)
                {
                    next[j + nums[i] + 1000] += dp[j + 1000];
                    next[j - nums[i] + 1000] += dp[j + 1000];
                }

            dp = next;
        }

        return S > 1000 ? 0 : dp[S + 1000];
    }
}
namespace LeetCode.Problems.Medium;

/// 面试题 08.11. 硬币
/// https://leetcode-cn.com/problems/coin-lcci/
public class MST0811
{
    public int WaysToChange(int n)
    {
        var dp = new int[n + 1];
        int[] coins = { 25, 10, 5, 1 };
        dp[0] = 1;
        for (var i = 0; i < coins.Length; i++)
        for (var j = coins[i]; j <= n; j++)
        {
            dp[j] += dp[j - coins[i]];
            dp[j] %= 1000000007;
        }

        return dp[n];
    }
}
namespace LeetCode.Problems.Hard;

/// 青蛙过河
/// https://leetcode-cn.com/problems/frog-jump/
public class P0403_FrogJump
{
    public bool CanCross(int[] stones)
    {
        for (var i = 1; i < stones.Length; i++)
            if (stones[i] - stones[i - 1] > i)
                return false;

        var n = stones.Length;
        var dp = new bool[n, n];
        dp[0, 0] = true;
        for (var i = 1; i < n; i++)
        for (var j = i - 1; j >= 0; j--)
        {
            var k = stones[i] - stones[j];
            if (k > j + 1) break;

            dp[i, k] = dp[j, k - 1] || dp[j, k] || dp[j, k + 1];
            if (i == n - 1 && dp[i, k]) return true;
        }

        return false;
    }
}
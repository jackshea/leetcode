namespace LeetCode.Problems.Hard;

/// 鸡蛋掉落
/// https://leetcode-cn.com/problems/super-egg-drop/
public class P0887_SuperEggDrop
{
    public int SuperEggDrop(int K, int N)
    {
        var dp = new int[K + 1];
        var m = 0;
        while (dp[K] < N)
        {
            for (var i = K; i >= 1; i--) dp[i] += dp[i - 1] + 1;

            m++;
        }

        return m;
    }
}
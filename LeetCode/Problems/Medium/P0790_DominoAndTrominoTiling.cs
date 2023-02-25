namespace LeetCode.Problems.Medium;

/// 多米诺和托米诺平铺
/// https://leetcode-cn.com/problems/domino-and-tromino-tiling/
public class P0790_DominoAndTrominoTiling
{
    private const int MOD = (int)1E9 + 7;

    public int NumTilings(int N)
    {
        if (N <= 1) return N;
        var preDp = new int[4];
        int[] dp = { 1, 0, 0, 1 };
        for (var i = 1; i < N; i++)
        {
            var temp = preDp;
            preDp = dp;
            dp = temp;
            dp[0] = preDp[3];
            dp[1] = (preDp[0] + preDp[2]) % MOD;
            dp[2] = (preDp[0] + preDp[1]) % MOD;
            dp[3] = 0;
            for (var j = 0; j < 4; j++) dp[3] = (dp[3] + preDp[j]) % MOD;
        }

        return dp[3];
    }
}
namespace LeetCode.Problems.Medium
{
    /// 不同的子序列
    /// https://leetcode-cn.com/problems/distinct-subsequences/
    public class P0115_DistinctSubsequences
    {
        public int NumDistinct(string s, string t)
        {
            var m = s.Length;
            var n = t.Length;
            if (n > m) return 0;
            if (s == t) return 1;
            if (m == n) return 0;

            int[,] dp = new int[m + 1, n + 1];
            for (int i = 0; i <= m; i++)
            {
                dp[i, 0] = 1;
            }

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s[i - 1] == t[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }

            return dp[m, n];
        }
    }
}
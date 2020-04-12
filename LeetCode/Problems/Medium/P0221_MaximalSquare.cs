using System;

namespace LeetCode.Problems.Medium
{
    /// 最大正方形
    /// https://leetcode-cn.com/problems/maximal-square/
    public class P0221_MaximalSquare
    {
        public int MaximalSquare(char[][] matrix)
        {
            var m = matrix.Length;
            if (m == 0)
            {
                return 0;
            }
            var n = matrix[0].Length;
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dp[i + 1, j + 1] = matrix[i][j] - '0';
                }
            }

            int ans = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (dp[i, j] == 1)
                    {
                        dp[i, j] = Math.Min(Math.Min(dp[i - 1, j - 1], dp[i, j - 1]), dp[i - 1, j]) + 1;
                        if (ans < dp[i, j])
                        {
                            ans = dp[i, j];
                        }
                    }
                }
            }

            return ans * ans;
        }
    }
}
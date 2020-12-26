using System;

namespace LeetCode.Problems.Hard
{
    /// 最大矩形
    /// https://leetcode-cn.com/problems/maximal-rectangle/
    public class P0085_MaximalRectangle
    {
        public int MaximalRectangle(char[][] matrix)
        {
            var m = matrix.Length;
            if (m == 0)
            {
                return 0;
            }

            int n = matrix[0].Length;
            int[,] left = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == '1')
                    {
                        left[i, j] = j == 0 ? 1 : left[i, j - 1] + 1;
                    }
                }
            }

            int ans = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == '0')
                    {
                        continue;
                    }

                    int w = left[i, j];
                    int area = w;
                    for (int k = i - 1; k >= 0; k--)
                    {
                        w = Math.Min(w, left[k, j]);
                        area = Math.Max(area, (i - k + 1) * w);
                    }

                    ans = Math.Max(ans, area);
                }
            }

            return ans;
        }
    }
}
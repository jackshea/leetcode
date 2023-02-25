using System;

namespace LeetCode.Problems.Hard;

/// 最大矩形
/// https://leetcode-cn.com/problems/maximal-rectangle/
public class P0085_MaximalRectangle
{
    public int MaximalRectangle(char[][] matrix)
    {
        var m = matrix.Length;
        if (m == 0) return 0;

        var n = matrix[0].Length;
        var left = new int[m, n];
        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
            if (matrix[i][j] == '1')
                left[i, j] = j == 0 ? 1 : left[i, j - 1] + 1;

        var ans = 0;
        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
        {
            if (matrix[i][j] == '0') continue;

            var w = left[i, j];
            var area = w;
            for (var k = i - 1; k >= 0; k--)
            {
                w = Math.Min(w, left[k, j]);
                area = Math.Max(area, (i - k + 1) * w);
            }

            ans = Math.Max(ans, area);
        }

        return ans;
    }
}
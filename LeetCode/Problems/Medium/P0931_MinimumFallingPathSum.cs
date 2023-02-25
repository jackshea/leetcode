using System;

namespace LeetCode.Problems.Medium;

/// 下降路径最小和
/// https://leetcode-cn.com/problems/minimum-falling-path-sum/
public class P0931_MinimumFallingPathSum
{
    public int MinFallingPathSum(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        for (var i = 1; i < m; i++)
        for (var j = 0; j < n; j++)
        {
            var min = int.MaxValue;
            for (var k = j - 1; k <= j + 1; k++)
                if (k >= 0 && k < n)
                    min = Math.Min(min, matrix[i - 1][k]);

            matrix[i][j] += min;
        }

        var ans = int.MaxValue;
        foreach (var num in matrix[m - 1]) ans = Math.Min(ans, num);

        return ans;
    }
}
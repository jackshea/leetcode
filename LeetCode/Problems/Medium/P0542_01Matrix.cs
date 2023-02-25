using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 01 矩阵
/// https://leetcode-cn.com/problems/01-matrix/
public class P0542_01Matrix
{
    private readonly int[] dc = { 0, 1, 0, -1 };
    private readonly int[] dr = { 1, 0, -1, 0 };

    public int[][] UpdateMatrix(int[][] matrix)
    {
        if (matrix.Length == 0) return matrix;

        var q = new Queue<int[]>();
        for (var i = 0; i < matrix.Length; i++)
        for (var j = 0; j < matrix[0].Length; j++)
            if (matrix[i][j] == 0)
                q.Enqueue(new[] { i, j });
            else
                matrix[i][j] = int.MaxValue;

        var dist = 0;
        while (q.Count != 0)
        {
            dist++;
            var count = q.Count;
            for (var i = 0; i < count; i++)
            {
                var pos = q.Dequeue();
                for (var j = 0; j < dr.Length; j++)
                {
                    var r = pos[0] + dr[j];
                    var c = pos[1] + dc[j];
                    if (r < 0 || r >= matrix.Length || c < 0 || c >= matrix[0].Length || matrix[r][c] < dist) continue;

                    matrix[r][c] = dist;
                    q.Enqueue(new[] { r, c });
                }
            }
        }

        return matrix;
    }
}
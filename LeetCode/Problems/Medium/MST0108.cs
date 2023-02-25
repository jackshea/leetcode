using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 零矩阵
/// https://leetcode-cn.com/problems/zero-matrix-lcci/
public class MST0108
{
    public void SetZeroes(int[][] matrix)
    {
        if (matrix == null || matrix.Length == 0) return;

        var zeroR = new HashSet<int>();
        var zeroC = new HashSet<int>();
        for (var i = 0; i < matrix.Length; i++)
        for (var j = 0; j < matrix[0].Length; j++)
            if (matrix[i][j] == 0)
            {
                zeroR.Add(i);
                zeroC.Add(j);
            }

        for (var i = 0; i < matrix.Length; i++)
        for (var j = 0; j < matrix[0].Length; j++)
            if (matrix[i][j] != 0 && (zeroR.Contains(i) || zeroC.Contains(j)))
                matrix[i][j] = 0;
    }
}
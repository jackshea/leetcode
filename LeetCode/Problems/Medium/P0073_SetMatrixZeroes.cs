namespace LeetCode.Problems.Medium;

/// 矩阵置零
/// https://leetcode-cn.com/problems/set-matrix-zeroes/
public class P0073_SetMatrixZeroes
{
    public void SetZeroes(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var zeroI = new bool[m];
        var zeroJ = new bool[n];
        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
            if (matrix[i][j] == 0)
            {
                zeroI[i] = true;
                zeroJ[j] = true;
            }

        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
            if (zeroI[i] || zeroJ[j])
                matrix[i][j] = 0;
    }
}
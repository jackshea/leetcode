using System;

namespace LeetCode.Problems.Medium;

/// 给定行和列的和求可行矩阵
/// https://leetcode.cn/problems/find-valid-matrix-given-row-and-column-sums/
public class P1605_FindValidMatrixGivenRowAndColumnSums
{
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
    {
        int m = rowSum.Length;
        int n = colSum.Length;
        int[][] matrix = new int[m][];
        int i, j = 0;
        for (i = 0; i < m; i++)
        {
            matrix[i] = new int[n];
        }

        i = 0;
        while (i < m && j < n)
        {
            matrix[i][j] = Math.Min(rowSum[i], colSum[j]);
            rowSum[i] -= matrix[i][j];
            colSum[j] -= matrix[i][j];
            if (rowSum[i] == 0)
            {
                i++;
            }

            if (colSum[j] == 0)
            {
                j++;
            }
        }
        return matrix;
    }
}
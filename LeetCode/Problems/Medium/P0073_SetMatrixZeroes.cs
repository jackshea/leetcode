using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 矩阵置零
    /// https://leetcode-cn.com/problems/set-matrix-zeroes/
    public class P0073_SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            bool[] zeroI = new bool[m];
            bool[] zeroJ = new bool[n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        zeroI[i] = true;
                        zeroJ[j] = true;
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (zeroI[i] || zeroJ[j])
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
    }
}
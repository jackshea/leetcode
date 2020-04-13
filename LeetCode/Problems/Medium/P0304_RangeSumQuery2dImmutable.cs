using System;

namespace LeetCode.Problems.Medium
{
    /// 二维区域和检索 - 矩阵不可变
    /// https://leetcode-cn.com/problems/range-sum-query-2d-immutable/
    public class NumMatrix
    {
        private int[][] matrix;

        public NumMatrix(int[][] matrix)
        {
            this.matrix = matrix;
            if (matrix.Length == 0)
            {
                return;
            }
            for (int i = 1; i < matrix.Length; i++)
            {
                matrix[i][0] += matrix[i - 1][0];
            }

            for (int i = 1; i < matrix[0].Length; i++)
            {
                matrix[0][i] += matrix[0][i - 1];
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    matrix[i][j] += matrix[i][j - 1] + matrix[i - 1][j] - matrix[i - 1][j - 1];
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            int r = row1 - 1;
            int c = col1 - 1;
            var sum = matrix[row2][col2];
            if (r >= 0)
            {
                sum -= matrix[r][col2];
            }

            if (c >= 0)
            {
                sum -= matrix[row2][c];
            }

            if (r >= 0 && c >= 0)
            {
                sum += matrix[r][c];
            }

            return sum;
        }
    }
}
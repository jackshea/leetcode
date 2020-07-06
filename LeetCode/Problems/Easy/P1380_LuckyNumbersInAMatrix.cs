using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 矩阵中的幸运数
    /// https://leetcode-cn.com/problems/lucky-numbers-in-a-matrix/
    public class P1380_LuckyNumbersInAMatrix
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            IList<int> ans = new List<int>();
            int m = matrix.Length;
            int n = matrix[0].Length;
            int[] row = new int[m];
            int[] col = new int[n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] < matrix[i][row[i]])
                    {
                        row[i] = j;
                    }

                    if (matrix[i][j] > matrix[col[j]][j])
                    {
                        col[j] = i;
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                if (i == col[row[i]])
                {
                    ans.Add(matrix[i][row[i]]);
                }
            }

            return ans;
        }
    }
}
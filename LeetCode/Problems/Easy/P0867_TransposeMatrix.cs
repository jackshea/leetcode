using System.Runtime.InteropServices;

namespace LeetCode.Problems
{
    /// 转置矩阵
    /// https://leetcode-cn.com/problems/transpose-matrix/
    public class P0867_TransposeMatrix
    {
        public int[][] Transpose(int[][] A)
        {
            var row = A.Length;
            var col = A[0].Length;
            int[][] ans = new int[col][];
            for (int i = 0; i < col; i++)
            {
                ans[i] = new int[row];
                for (int j = 0; j < row; j++)
                {
                    ans[i][j] = A[j][i];
                }
            }

            return ans;
        }
    }
}
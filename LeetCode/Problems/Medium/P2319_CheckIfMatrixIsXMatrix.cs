namespace LeetCode.Problems.Medium
{
    /// 判断矩阵是否是一个 X 矩阵
    /// https://leetcode.cn/problems/check-if-matrix-is-x-matrix/
    public class P2319_CheckIfMatrixIsXMatrix
    {
        public bool CheckXMatrix(int[][] grid)
        {
            int n = grid.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j || i == n - j - 1)
                    {
                        if (grid[i][j] == 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (grid[i][j] != 0)
                        {
                            return false;
                        }
                    }

                }
            }

            return true;
        }
    }
}
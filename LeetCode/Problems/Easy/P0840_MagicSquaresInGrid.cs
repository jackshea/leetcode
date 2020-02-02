namespace LeetCode.Problems
{
    /// 矩阵中的幻方
    /// https://leetcode-cn.com/problems/magic-squares-in-grid/
    public class P0840_MagicSquaresInGrid
    {
        public int NumMagicSquaresInside(int[][] grid)
        {
            int ans = 0;
            for (int i = 1; i < grid.Length - 1; i++)
            {
                for (int j = 1; j < grid[0].Length - 1; j++)
                {
                    if (grid[i][j] == 5 && CheckSum(grid, i, j) && CheckUnique(grid, i, j))
                    {
                        ans++;
                    }
                }
            }

            return ans;
        }

        /// 检查和
        private bool CheckSum(int[][] grid, int r, int c)
        {
            // 行和
            for (int i = r - 1; i <= r + 1; i++)
            {
                int sum = 0;
                for (int j = c - 1; j <= c + 1; j++)
                {
                    sum += grid[i][j];
                }

                if (sum != 15)
                {
                    return false;
                }
            }

            // 列和
            for (int i = c - 1; i <= c + 1; i++)
            {
                int sum = 0;
                for (int j = r - 1; j <= r + 1; j++)
                {
                    sum += grid[j][i];
                }

                if (sum != 15)
                {
                    return false;
                }
            }

            // 对角和
            int sum1 = 0;
            int sum2 = 0;
            for (int i = -1; i <= 1; i++)
            {
                sum1 += grid[r + i][c + i];
                sum2 += grid[r - i][c - i];
            }

            return sum1 == 15 && sum2 == 15;
        }

        /// 检查唯一
        private bool CheckUnique(int[][] grid, int r, int c)
        {
            bool[] isExsist = new bool[10];
            for (int i = r - 1; i <= r + 1; i++)
            {
                for (int j = c - 1; j <= c + 1; j++)
                {
                    var num = grid[i][j];
                    if (num >= 10)
                    {
                        return false;
                    }

                    if (isExsist[num])
                    {
                        return false;
                    }

                    isExsist[num] = true;
                }
            }

            return true;
        }
    }
}
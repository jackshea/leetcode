namespace LeetCode.Problems.Medium
{
    /// 不同路径 II
    /// https://leetcode-cn.com/problems/unique-paths-ii/
    public class P0063_UniquePathsII
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            var m = obstacleGrid.Length;
            var n = obstacleGrid[0].Length;

            if (obstacleGrid[0][0] == 1)
            {
                return 0;
            }

            // 将障碍格子设为-1
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        obstacleGrid[i][j] = -1;
                    }
                }
            }

            for (int i = m - 1; i >= 0; i--)
            {
                if (obstacleGrid[i][n - 1] == -1)
                {
                    break;
                }

                obstacleGrid[i][n - 1] = 1;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                if (obstacleGrid[m - 1][i] == -1)
                {
                    break;
                }

                obstacleGrid[m - 1][i] = 1;
            }

            for (int i = m - 2; i >= 0; i--)
            {
                for (int j = n - 2; j >= 0; j--)
                {
                    if (obstacleGrid[i][j] == -1)
                    {
                        continue;
                    }

                    obstacleGrid[i][j] = GetPaths(obstacleGrid, i, j + 1) + GetPaths(obstacleGrid, i + 1, j);
                }
            }

            return obstacleGrid[0][0];
        }

        private int GetPaths(int[][] obstacleGrid, int row, int col)
        {
            return obstacleGrid[row][col] == -1 ? 0 : obstacleGrid[row][col];
        }
    }
}
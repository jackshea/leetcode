namespace LeetCode.Problems.Medium
{
    /// 不同路径
    /// https://leetcode-cn.com/problems/unique-paths/
    public class P0062_UniquePaths
    {
        public int UniquePaths(int m, int n)
        {
            int[,] grid = new int[m, n];
            for (int i = 0; i < n; i++)
            {
                grid[m - 1, i] = 1;
            }
            for (int i = 0; i < m; i++)
            {
                grid[i, n - 1] = 1;
            }

            for (int i = m - 2; i >= 0; i--)
            {
                for (int j = n - 2; j >= 0; j--)
                {
                    grid[i, j] = grid[i + 1, j] + grid[i, j + 1];
                }
            }

            return grid[0, 0];
        }
    }
}
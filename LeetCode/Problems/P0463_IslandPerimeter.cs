namespace LeetCode.Problems
{
    /// 岛屿的周长
    /// https://leetcode-cn.com/problems/island-perimeter/
    public class P0463_IslandPerimeter
    {
        public int IslandPerimeter(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int perimeter = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        perimeter += 4;
                        if (i > 0 && grid[i - 1][j] == 1)
                        {
                            perimeter -= 2;
                        }

                        if (j > 0 && grid[i][j - 1] == 1)
                        {
                            perimeter -= 2;
                        }
                    }

                }

            }

            return perimeter;
        }
    }
}
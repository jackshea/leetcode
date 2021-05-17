using System;

namespace LeetCode.Problems.Medium
{
    /// 保持城市天际线
    /// https://leetcode-cn.com/problems/max-increase-to-keep-city-skyline/
    public class P0807_MaxIncreaseToKeepCitySkyline
    {
        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            int[] rowSkyline = new int[grid.Length];
            int[] colSkyline = new int[grid[0].Length];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    rowSkyline[i] = Math.Max(rowSkyline[i], grid[i][j]);
                    colSkyline[j] = Math.Max(colSkyline[j], grid[i][j]);
                }
            }

            int sum = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    sum += Math.Min(rowSkyline[i], colSkyline[j])- grid[i][j];
                }
            }

            return sum;
        }
    }
}
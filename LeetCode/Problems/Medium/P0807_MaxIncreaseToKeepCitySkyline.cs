using System;

namespace LeetCode.Problems.Medium;

/// 保持城市天际线
/// https://leetcode-cn.com/problems/max-increase-to-keep-city-skyline/
public class P0807_MaxIncreaseToKeepCitySkyline
{
    public int MaxIncreaseKeepingSkyline(int[][] grid)
    {
        var rowSkyline = new int[grid.Length];
        var colSkyline = new int[grid[0].Length];
        for (var i = 0; i < grid.Length; i++)
        for (var j = 0; j < grid[i].Length; j++)
        {
            rowSkyline[i] = Math.Max(rowSkyline[i], grid[i][j]);
            colSkyline[j] = Math.Max(colSkyline[j], grid[i][j]);
        }

        var sum = 0;
        for (var i = 0; i < grid.Length; i++)
        for (var j = 0; j < grid[i].Length; j++)
            sum += Math.Min(rowSkyline[i], colSkyline[j]) - grid[i][j];

        return sum;
    }
}
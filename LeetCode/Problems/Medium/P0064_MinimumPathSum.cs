using System;

namespace LeetCode.Problems.Medium;

/// 最小路径和
/// https://leetcode-cn.com/problems/minimum-path-sum/
public class P0064_MinimumPathSum
{
    private int[,] cost; // 当前位置到终点的最小花费

    public int MinPathSum(int[][] grid)
    {
        cost = new int[grid.Length, grid[0].Length];
        return MinCost(grid, 0, 0);
    }

    /// 以r,c 为起点到终点的最小花费
    private int MinCost(int[][] grid, int r, int c)
    {
        // 终点
        if (r == grid.Length - 1 && c == grid[0].Length - 1) return grid[r][c];

        // 超出边界
        if (r >= grid.Length || c >= grid[0].Length) return int.MaxValue;

        // 未计算花费
        if (cost[r, c] == 0) cost[r, c] = grid[r][c] + Math.Min(MinCost(grid, r + 1, c), MinCost(grid, r, c + 1));

        return cost[r, c];
    }
}

/// 不需要额外空间
public class P0064_MinimumPathSum_1
{
    public int MinPathSum(int[][] grid)
    {
        for (var i = grid.Length - 1; i >= 0; i--)
        for (var j = grid[0].Length - 1; j >= 0; j--)
            if (i == grid.Length - 1 && j < grid[0].Length - 1)
                grid[i][j] += grid[i][j + 1];
            else if (i < grid.Length - 1 && j == grid[0].Length - 1)
                grid[i][j] += grid[i + 1][j];
            else if (i < grid.Length - 1 && j < grid[0].Length - 1)
                grid[i][j] += Math.Min(grid[i][j + 1], grid[i + 1][j]);

        return grid[0][0];
    }
}
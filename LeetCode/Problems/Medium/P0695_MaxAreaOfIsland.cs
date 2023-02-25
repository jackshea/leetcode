using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 岛屿的最大面积
/// https://leetcode-cn.com/problems/max-area-of-island/
public class P0695_MaxAreaOfIsland
{
    // 上下左右 四个方向
    private readonly int[] dirx = { 1, -1, 0, 0 };
    private readonly int[] diry = { 0, 0, 1, -1 };
    private readonly HashSet<int> visited = new(); // 记录访问过的坐标 x*1000+y

    public int MaxAreaOfIsland(int[][] grid)
    {
        var ans = 0;
        for (var i = 0; i < grid.Length; i++)
        for (var j = 0; j < grid[0].Length; j++)
        {
            // 排除 水域和已访问过的陆地
            if (grid[i][j] == 0 || visited.Contains(i * 1000 + j)) continue;

            var area = CalcArea(grid, i, j);
            if (ans < area) ans = area;
        }

        return ans;
    }

    // DFS 计算小岛的面积 并标记已访问过的陆地
    private int CalcArea(int[][] grid, int x, int y)
    {
        if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length) return 0;

        if (grid[x][y] == 0 || visited.Contains(x * 1000 + y)) return 0;

        visited.Add(x * 1000 + y);
        var area = 1;
        for (var i = 0; i < dirx.Length; i++) area += CalcArea(grid, x + dirx[i], y + diry[i]);

        return area;
    }
}
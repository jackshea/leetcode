namespace LeetCode.Problems.Medium;

/// 岛屿数量
/// https://leetcode-cn.com/problems/number-of-islands/
public class P0200_NumberOfIslands
{
    private readonly int[] dx = { 1, -1, 0, 0 };
    private readonly int[] dy = { 0, 0, 1, -1 };

    public int NumIslands(char[][] grid)
    {
        var ans = 0;
        for (var i = 0; i < grid.Length; i++)
        for (var j = 0; j < grid[0].Length; j++)
            if (grid[i][j] == '1')
            {
                ans++;
                DFS(grid, i, j);
            }

        return ans;
    }

    private void DFS(char[][] grid, int x, int y)
    {
        if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length || grid[x][y] != '1') return;

        grid[x][y] = '0';

        for (var i = 0; i < dx.Length; i++) DFS(grid, x + dx[i], y + dy[i]);
    }
}
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 迷路的机器人
/// https://leetcode-cn.com/problems/robot-in-a-grid-lcci/
public class MST0802
{
    private bool[,] visited;

    public IList<IList<int>> PathWithObstacles(int[][] obstacleGrid)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        if (obstacleGrid == null || obstacleGrid.Length == 0) return ans;

        visited = new bool[obstacleGrid.Length, obstacleGrid[0].Length];
        DFS(obstacleGrid, 0, 0, ans);
        return ans;
    }

    private bool DFS(int[][] obstacleGrid, int r, int c, IList<IList<int>> path)
    {
        if (r >= obstacleGrid.Length || c >= obstacleGrid[0].Length) return false;

        if (visited[r, c]) return false;
        visited[r, c] = true;

        if (obstacleGrid[r][c] == 1) return false;

        if (r == obstacleGrid.Length - 1 && c == obstacleGrid[0].Length - 1)
        {
            path.Add(new List<int> { r, c });
            return true;
        }

        path.Add(new List<int> { r, c });
        if (DFS(obstacleGrid, r + 1, c, path) || DFS(obstacleGrid, r, c + 1, path)) return true;
        path.RemoveAt(path.Count - 1);
        return false;
    }
}
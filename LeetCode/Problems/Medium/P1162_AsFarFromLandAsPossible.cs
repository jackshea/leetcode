using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 地图分析
/// https://leetcode-cn.com/problems/as-far-from-land-as-possible/
public class P1162_AsFarFromLandAsPossible
{
    private readonly int[] dm = { 1, 0, -1, 0 };
    private readonly int[] dn = { 0, 1, 0, -1 };
    private int distance;
    private Queue<int[]> edge;
    private int[][] grid;
    private int m;
    private int n;

    public int MaxDistance(int[][] grid)
    {
        this.grid = grid;
        m = grid.Length;
        if (m < 0) return -1;
        n = grid[0].Length;
        if (IsAll(0) || IsAll(1)) return -1;
        edge = new Queue<int[]>();
        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
            if (grid[i][j] == 1)
                edge.Enqueue(new[] { i, j });
        BFS();
        return distance;
    }

    /// 广度优先搜索
    private void BFS()
    {
        while (edge.Count > 0)
        {
            var edgeCount = edge.Count;
            for (var i = 0; i < edgeCount; i++)
            {
                var pos = edge.Dequeue();
                for (var j = 0; j < dm.Length; j++)
                {
                    var mm = pos[0] + dm[j];
                    var nn = pos[1] + dn[j];
                    if (mm >= 0 && mm < m && nn >= 0 && nn < n && grid[mm][nn] == 0)
                    {
                        grid[mm][nn] = 1;
                        edge.Enqueue(new[] { mm, nn });
                    }
                }
            }

            if (edge.Count > 0) distance++;
        }
    }

    private bool IsAll(int v)
    {
        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
            if (grid[i][j] != v)
                return false;

        return true;
    }
}
using System;
using System.Collections.Generic;

namespace LeetCode.Contest.Biweekly.C046;

/// 地图中的最高点
/// https://leetcode-cn.com/contest/biweekly-contest-46/problems/map-of-highest-peak/
public class P5671 // BFS通过
{
    private readonly int[] dirX = { 1, 0, -1, 0 };
    private readonly int[] dirY = { 0, 1, 0, -1 };
    private int m;
    private int[][] map;
    private int n;

    public int[][] HighestPeak(int[][] isWater)
    {
        m = isWater.Length;
        n = isWater[0].Length;
        map = new int[m][];
        for (var i = 0; i < m; i++) map[i] = new int[n];

        var visited = new HashSet<int>();
        var q = new Queue<int[]>();
        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
            if (isWater[i][j] == 1)
            {
                q.Enqueue(new[] { i, j });
                visited.Add(i * 10000 + j);
            }

        while (q.Count > 0)
        {
            var top = q.Dequeue();
            for (var i = 0; i < dirX.Length; i++)
            {
                var nx = top[0] + dirX[i];
                var ny = top[1] + dirY[i];
                if (0 <= nx && nx < m && 0 <= ny && ny < n && !visited.Contains(nx * 10000 + ny))
                {
                    map[nx][ny] = map[top[0]][top[1]] + 1;
                    q.Enqueue(new[] { nx, ny });
                    visited.Add(nx * 10000 + ny);
                }
            }
        }

        return map;
    }
}

/// DFS超时
public class P5671_1
{
    private readonly int[] dirX = { 1, 0, -1, 0 };
    private readonly int[] dirY = { 0, 1, 0, -1 };
    private int[][] isWater;
    private int m;
    private int[][] map;
    private int n;

    public int[][] HighestPeak(int[][] isWater)
    {
        this.isWater = isWater;
        m = isWater.Length;
        n = isWater[0].Length;
        map = new int[m][];
        for (var i = 0; i < m; i++)
        {
            map[i] = new int[n];
            Array.Fill(map[i], int.MaxValue);
        }

        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
            if (isWater[i][j] == 1)
            {
                map[i][j] = 0;
                DFS(i, j, 0);
            }

        return map;
    }

    public void DFS(int x, int y, int height)
    {
        for (var i = 0; i < dirX.Length; i++)
        {
            var nx = x + dirX[i];
            var ny = y + dirY[i];
            if (0 <= nx && nx < m && 0 <= ny && ny < n && isWater[nx][ny] == 0)
                if (map[nx][ny] > height + 1)
                {
                    map[nx][ny] = height + 1;
                    DFS(nx, ny, height + 1);
                }
        }
    }
}

/// n^3 超时
public class P5671_2
{
    private int m;
    private int[][] map;
    private int n;

    public int[][] HighestPeak(int[][] isWater)
    {
        m = isWater.Length;
        n = isWater[0].Length;
        map = new int[m][];
        for (var i = 0; i < m; i++) map[i] = new int[n];

        var waterCells = new List<int[]>();
        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
            if (isWater[i][j] == 1)
                waterCells.Add(new[] { i, j });

        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
        {
            if (isWater[i][j] == 1) continue;

            var dist = int.MaxValue;
            foreach (var waterCell in waterCells)
            {
                dist = Math.Min(dist, Math.Abs(waterCell[0] - i) + Math.Abs(waterCell[1] - j));
                if (dist == 1) break;
            }

            map[i][j] = dist;
        }

        return map;
    }
}
using System;
using System.Collections.Generic;

namespace LeetCode.Contest.Biweekly.C046
{
    /// 地图中的最高点
    /// https://leetcode-cn.com/contest/biweekly-contest-46/problems/map-of-highest-peak/
    public class P5671 // 超时
    {
        private int[][] map;
        private int m;
        private int n;
        private int[][] isWater;
        private int[] dirX = { 1, 0, -1, 0 };
        private int[] dirY = { 0, 1, 0, -1 };

        public int[][] HighestPeak(int[][] isWater)
        {
            this.isWater = isWater;
            m = isWater.Length;
            n = isWater[0].Length;
            map = new int[m][];
            for (int i = 0; i < m; i++)
            {
                map[i] = new int[n];
                Array.Fill(map[i], int.MaxValue);
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (isWater[i][j] == 1)
                    {
                        map[i][j] = 0;
                        DFS(i, j, 0);
                    }
                }
            }

            return map;
        }

        public void DFS(int x, int y, int height)
        {
            for (int i = 0; i < dirX.Length; i++)
            {
                int nx = x + dirX[i];
                int ny = y + dirY[i];
                if (0 <= nx && nx < m && 0 <= ny && ny < n && isWater[nx][ny] == 0)
                {
                    if (map[nx][ny] > height + 1)
                    {
                        map[nx][ny] = height + 1;
                        DFS(nx, ny, height + 1);
                    }
                }
            }
        }
    }

    public class P5671_1 // 超时
    {
        private int[][] map;
        private int m;
        private int n;

        public int[][] HighestPeak(int[][] isWater)
        {
            m = isWater.Length;
            n = isWater[0].Length;
            map = new int[m][];
            for (int i = 0; i < m; i++)
            {
                map[i] = new int[n];
            }

            List<int[]> waterCells = new List<int[]>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (isWater[i][j] == 1)
                    {
                        waterCells.Add(new[] { i, j });
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (isWater[i][j] == 1)
                    {
                        continue;
                    }

                    int dist = int.MaxValue;
                    foreach (var waterCell in waterCells)
                    {
                        dist = Math.Min(dist, Math.Abs(waterCell[0] - i) + Math.Abs(waterCell[1] - j));
                    }

                    map[i][j] = dist;
                }
            }

            return map;
        }
    }
}
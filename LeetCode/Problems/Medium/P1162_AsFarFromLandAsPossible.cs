using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 地图分析
    /// https://leetcode-cn.com/problems/as-far-from-land-as-possible/
    public class P1162_AsFarFromLandAsPossible
    {
        private int[][] grid;
        private int m;
        private int n;
        private int distance;
        private Queue<int[]> edge;
        private int[] dm = { 1, 0, -1, 0 };
        private int[] dn = { 0, 1, 0, -1 };

        public int MaxDistance(int[][] grid)
        {
            this.grid = grid;
            m = grid.Length;
            if (m < 0)
            {
                return -1;
            }
            n = grid[0].Length;
            if (IsAll(0) || IsAll(1))
            {
                return -1;
            }
            edge = new Queue<int[]>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        edge.Enqueue(new int[] { i, j });
                    }
                }
            }
            BFS();
            return distance;
        }

        /// 广度优先搜索
        private void BFS()
        {
            while (edge.Count > 0)
            {
                var edgeCount = edge.Count;
                for (int i = 0; i < edgeCount; i++)
                {
                    var pos = edge.Dequeue();
                    for (int j = 0; j < dm.Length; j++)
                    {
                        int mm = pos[0] + dm[j];
                        int nn = pos[1] + dn[j];
                        if (mm >= 0 && mm < m && nn >= 0 && nn < n && grid[mm][nn] == 0)
                        {
                            grid[mm][nn] = 1;
                            edge.Enqueue(new[] { mm, nn });
                        }
                    }
                }

                if (edge.Count > 0)
                {
                    distance++;
                }
            }
        }

        private bool IsAll(int v)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] != v)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
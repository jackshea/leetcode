using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 腐烂的橘子
    /// https://leetcode-cn.com/problems/rotting-oranges/
    public class P0994_RottingOranges
    {
        public int OrangesRotting(int[][] grid)
        {
            Queue<int[]> badOrange = new Queue<int[]>();
            int ans = -1;
            bool existFreshOrange = false;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        existFreshOrange = true;
                    }

                    if (grid[i][j] == 2)
                    {
                        badOrange.Enqueue(new int[] { i, j });
                        ans = 0;
                    }
                }
            }

            if (!existFreshOrange)
            {
                return 0;
            }

            if (ans < 0)
            {
                return -1;
            }

            var nearly = new int[][] { new[] { 1, 0 }, new[] { -1, 0 }, new[] { 0, -1 }, new[] { 0, 1 } };

            while (badOrange.Count > 0)
            {
                int count = badOrange.Count;
                for (int i = 0; i < count; i++)
                {
                    var top = badOrange.Dequeue();
                    foreach (var n in nearly)
                    {
                        int ii = top[0] + n[0];
                        int jj = top[1] + n[1];
                        if (ii >= 0 && ii < grid.Length && jj >= 0 && jj < grid[0].Length && grid[ii][jj] == 1)
                        {
                            grid[ii][jj] = 2;
                            badOrange.Enqueue(new int[] { ii, jj });
                        }
                    }
                }

                if (badOrange.Count > 0)
                {
                    ans++;
                }
            }

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        return -1;
                    }
                }
            }

            return ans;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 水域大小
    /// https://leetcode-cn.com/problems/pond-sizes-lcci/
    public class MST1619
    {
        List<int> ans = new List<int>();
        public int[] PondSizes(int[][] land)
        {
            if (land == null || land.Length == 0)
            {
                return new int[0];
            }

            for (int i = 0; i < land.Length; i++)
            {
                for (int j = 0; j < land[0].Length; j++)
                {
                    var count = BFS(land, i, j);
                    if (count != 0)
                    {
                        ans.Add(count);
                    }
                }
            }

            ans.Sort();
            return ans.ToArray();
        }

        private int BFS(int[][] land, int r, int c)
        {
            if (r < 0 || r >= land.Length || c < 0 || c >= land[0].Length || land[r][c] != 0)
            {
                return 0;
            }

            land[r][c] = -1;
            int count = 1;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }

                    count += BFS(land, r + i, c + j);
                }
            }

            return count;
        }
    }
}
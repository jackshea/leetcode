using System;

namespace LeetCode.Problems.Easy
{
    /// 三维形体的表面积
    /// https://leetcode-cn.com/problems/surface-area-of-3d-shapes/
    public class P0892_SurfaceAreaOf3dShapes
    {
        public int SurfaceArea(int[][] grid)
        {
            int ans = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    // 一个立方体的表面积，不考虑相邻情况
                    // 四周的面积加上 上底和下底
                    var n = grid[i][j];
                    if (n > 0)
                    {
                        ans += 4 * n + 2;
                    }

                    // 相邻情况处理
                    if (i != grid.Length - 1)
                    {
                        ans -= Math.Min(n, grid[i + 1][j]) * 2;// 减去下边重合的表面积
                    }

                    if (j != grid[0].Length - 1)
                    {
                        ans -= Math.Min(n, grid[i][j + 1]) * 2;// 减去右边重合的表面积
                    }
                }
            }

            return ans;
        }
    }
}
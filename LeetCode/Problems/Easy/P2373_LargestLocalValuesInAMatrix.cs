using System;

namespace LeetCode.Problems.Easy;

/// 矩阵中的局部最大值
/// https://leetcode.cn/problems/largest-local-values-in-a-matrix/
public class P2373_LargestLocalValuesInAMatrix
{
    public int[][] LargestLocal(int[][] grid)
    {
        int n = grid.Length - 2;
        int[][] ans = new int[n][];
        for (int i = 0; i < n; i++)
        {
            ans[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                ans[i][j] = Max(grid, i + 1, j + 1);
            }
        }

        return ans;
    }

    public int Max(int[][] grid, int x, int y)
    {
        int max = 0;
        for (int i = x - 1; i <= x + 1; i++)
        {
            for (int j = y - 1; j <= y + 1; j++)
            {
                max = Math.Max(max, grid[i][j]);
            }
        }
        return max;
    }
}
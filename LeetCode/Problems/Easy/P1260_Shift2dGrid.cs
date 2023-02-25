using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

public class P1260_Shift2dGrid
{
    /// 二维网格迁移
    /// https://leetcode-cn.com/problems/shift-2d-grid/
    public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        var r = grid.Length;
        var c = grid[0].Length;
        var length = r * c;
        k %= length;
        var ans = new List<IList<int>>();
        var newIndex = length - k;
        for (var i = 0; i < r; i++)
        {
            IList<int> row = new List<int>();
            for (var j = 0; j < c; j++)
            {
                newIndex %= length;
                row.Add(grid[newIndex / c][newIndex % c]);
                newIndex++;
            }

            ans.Add(row);
        }

        return ans;
    }
}
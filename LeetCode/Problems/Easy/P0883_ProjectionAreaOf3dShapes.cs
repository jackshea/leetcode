using System.Linq;

namespace LeetCode.Problems.Easy;

/// 三维形体投影面积
/// https://leetcode-cn.com/problems/projection-area-of-3d-shapes/
public class P0883_ProjectionAreaOf3dShapes
{
    public int ProjectionArea(int[][] grid)
    {
        int xy = 0, yz = 0;
        var xz = new int[grid[0].Length];
        for (var i = 0; i < grid.Length; i++)
        {
            var maxInRow = 0;
            for (var j = 0; j < grid[0].Length; j++)
            {
                var v = grid[i][j];
                if (v != 0) xy++;
                if (v > maxInRow) maxInRow = v;

                if (v > xz[j]) xz[j] = v;
            }

            yz += maxInRow;
        }

        return xy + yz + xz.Sum();
    }
}
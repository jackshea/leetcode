using System;

namespace LeetCode.Problems.Easy
{
    /// 距离顺序排列矩阵单元格
    /// https://leetcode-cn.com/problems/matrix-cells-in-distance-order/
    public class P1030_MatrixCellsInDistanceOrder
    {
        public int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {
            var ans = new int[R * C][];
            var ansIndex = 0;
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    ans[ansIndex++] = new[] { i, j };
                }
            }

            Array.Sort(ans, (a, b) => Dist(a[0], a[1], r0, c0).CompareTo(Dist(b[0], b[1], r0, c0)));
            return ans;
        }

        private int Dist(int r, int c, int r0, int c0)
        {
            return Math.Abs(r - r0) + Math.Abs(c - c0);
        }
    }
}
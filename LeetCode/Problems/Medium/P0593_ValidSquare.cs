using System;

namespace LeetCode.Problems.Medium
{
    /// 有效的正方形
    /// https://leetcode-cn.com/problems/valid-square/
    public class P0593_ValidSquare
    {
        public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            int[][] p = new[] { p1, p2, p3, p4 };
            Array.Sort(p, (a, b) =>
            {
                if (a[0] == b[0])
                {
                    return a[1].CompareTo(b[1]);
                }

                return a[0].CompareTo(b[0]);
            });
            int[] temp = p[2];
            p[2] = p[3];
            p[3] = temp;
            // 四条边相等且不为0，对角线相等
            var dist = Dist(p[0], p[1]);
            return dist != 0 && 
                   Dist(p[1], p[2]) == dist && Dist(p[2], p[3]) == dist && Dist(p[3], p[0]) == dist &&
                   Dist(p[0], p[2]) == Dist(p[1], p[3]);
        }

        public int Dist(int[] p1, int[] p2)
        {
            int x = p1[0] - p2[0];
            int y = p1[1] - p2[1];
            return x * x + y * y;
        }
    }
}
using System;

namespace LeetCode.Problems
{
    /// 最大三角形面积
    /// https://leetcode-cn.com/problems/largest-triangle-area/
    public class P0812_LargestTriangleArea
    {
        public double LargestTriangleArea(int[][] points)
        {
            double ans = 0;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    for (int k = j + 1; k < points.Length; k++)
                    {
                        ans = Math.Max(ans, Area(points[i], points[j], points[k]));
                    }
                }
            }

            return ans;
        }

        public double Area(int[] a, int[] b, int[] c)
        {
            return 0.5 * Math.Abs(a[0] * b[1] + b[0] * c[1] + c[0] * a[1]
                                  - a[1] * b[0] - b[1] * c[0] - c[1] * a[0]);
        }
    }
}
using System;

namespace LeetCode.Problems
{
    /// 访问所有点的最小时间
    /// https://leetcode-cn.com/problems/minimum-time-visiting-all-points/
    public class P1266_MinimumTimeVisitingAllPoints
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int ans = 0;
            for (var i = 0; i < points.Length - 1; i++)
            {
                var p1 = points[i];
                var p2 = points[i + 1];
                int x = Math.Abs(p1[0] - p2[0]);
                int y = Math.Abs(p1[1] - p2[1]);
                ans += Math.Max(x, y);
            }

            return ans;
        }
    }
}
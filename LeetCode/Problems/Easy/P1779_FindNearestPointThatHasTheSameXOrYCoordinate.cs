using System;

namespace LeetCode.Problems.Easy
{
    /// 找到最近的有相同 X 或 Y 坐标的点
    /// https://leetcode-cn.com/problems/find-nearest-point-that-has-the-same-x-or-y-coordinate/
    public class P1779_FindNearestPointThatHasTheSameXOrYCoordinate
    {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            int ans = -1;
            int minDist = int.MaxValue;
            for (var i = 0; i < points.Length; i++)
            {
                var point = points[i];
                if (point[0] != x && point[1] != y)
                {
                    continue;
                }

                int dist = Math.Abs(x - point[0]) + Math.Abs(y - point[1]);
                if (dist<minDist)
                {
                    minDist = dist;
                    ans = i;
                }
            }

            return ans;
        }
    }
}
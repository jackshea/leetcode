using System;

namespace LeetCode.Problems.Medium;

/// 两点之间不包含任何点的最宽垂直区域
/// https://leetcode.cn/problems/widest-vertical-area-between-two-points-containing-no-points/
public class P1637_WidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        Array.Sort(points, (a, b) =>
        {
            return a[0].CompareTo(b[0]);
        });
        int ans = 0;
        for (int i = 1; i < points.Length; i++)
        {
            ans = Math.Max(ans, points[i][0] - points[i - 1][0]);
        }
        return ans;
    }
}
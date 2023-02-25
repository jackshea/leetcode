using System;

namespace LeetCode.Problems.Medium;

/// 两点之间不包含任何点的最宽垂直面积
/// https://leetcode-cn.com/contest/biweekly-contest-38/problems/widest-vertical-area-between-two-points-containing-no-points/
public class P5540
{
    public int MaxWidthOfVerticalArea(int[][] points)
    {
        Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));
        var maxDiff = 0;
        for (var i = 1; i < points.Length; i++)
        {
            var diff = points[i][0] - points[i - 1][0];
            if (diff > maxDiff) maxDiff = diff;
        }

        return maxDiff;
    }
}
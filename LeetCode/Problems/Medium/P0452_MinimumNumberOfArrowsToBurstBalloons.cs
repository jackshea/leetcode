using System;

namespace LeetCode.Problems.Medium;

/// 用最少数量的箭引爆气球
/// https://leetcode-cn.com/problems/minimum-number-of-arrows-to-burst-balloons/
public class P0452_MinimumNumberOfArrowsToBurstBalloons
{
    public int FindMinArrowShots(int[][] points)
    {
        if (points.Length <= 1) return points.Length;
        // 按结束端点从小到大排序
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
        var ans = 1;
        var end = points[0][1];
        for (var i = 1; i < points.Length; i++)
            if (points[i][0] > end)
            {
                ans++;
                end = points[i][1];
            }

        return ans;
    }
}
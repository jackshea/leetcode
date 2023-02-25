using System;

namespace LeetCode.Problems.Easy;

/// 两地调度
/// https://leetcode-cn.com/problems/two-city-scheduling/
public class P1029_TwoCityScheduling
{
    public int TwoCitySchedCost(int[][] costs)
    {
        // 按差值排序
        Array.Sort(costs, (a, b) => { return (a[0] - a[1]).CompareTo(b[0] - b[1]); });
        var sum = 0;
        var half = costs.Length / 2;
        for (var i = 0; i < costs.Length; i++)
            if (i < half)
                sum += costs[i][0];
            else
                sum += costs[i][1];

        return sum;
    }
}
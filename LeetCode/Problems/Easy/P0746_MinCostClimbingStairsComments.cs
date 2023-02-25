using System;

namespace LeetCode.Problems.Easy;

/// 使用最小花费爬楼梯
/// https://leetcode-cn.com/problems/min-cost-climbing-stairs/comments/
public class P0746_MinCostClimbingStairsComments
{
    public int MinCostClimbingStairs(int[] cost)
    {
        var totalCost1 = cost[0]; // 已经过的第二近的台阶的总花费 
        var totalCost2 = cost[1]; // 已经过的最近的台阶的总花费
        for (var i = 2; i < cost.Length; i++)
        {
            var currentTotalCost = cost[i] + Math.Min(totalCost1, totalCost2); // 当前台阶最低总花费
            totalCost1 = totalCost2;
            totalCost2 = currentTotalCost;
        }

        return Math.Min(totalCost1, totalCost2);
    }
}
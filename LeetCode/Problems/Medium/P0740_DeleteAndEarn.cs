using System;
using System.Linq;

namespace LeetCode.Problems.Medium;

/// 删除与获得点数
/// https://leetcode-cn.com/problems/delete-and-earn/
public class P0740_DeleteAndEarn
{
    public int DeleteAndEarn(int[] nums)
    {
        var max = nums.Max();
        var points = new int[max + 1];
        foreach (var num in nums) points[num] += num;

        var dp0 = 0; // 前一个没选的最大值
        var dp1 = points[0]; // 前一个选了的最大值

        for (var i = 1; i < points.Length; i++)
        {
            var newDp0 = Math.Max(dp0, dp1);
            dp1 = dp0 + points[i];
            dp0 = newDp0;
        }

        return Math.Max(dp0, dp1);
    }
}
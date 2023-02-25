using System;

namespace LeetCode.Problems.Easy;

/// 打家劫舍
/// https://leetcode-cn.com/problems/house-robber/
public class P0198_HouseRobber
{
    public int Rob(int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;

        var dp0 = 0; // 前一个没选的最大值
        var dp1 = nums[0]; // 前一个选了的最大值

        for (var i = 1; i < nums.Length; i++)
        {
            var newDp0 = Math.Max(dp0, dp1);
            dp1 = dp0 + nums[i];
            dp0 = newDp0;
        }

        return Math.Max(dp0, dp1);
    }
}
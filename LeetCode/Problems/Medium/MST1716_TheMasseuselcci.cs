using System;

namespace LeetCode.Problems.Medium;

/// 面试题 17.16. 按摩师
/// https://leetcode-cn.com/problems/the-masseuse-lcci/
public class MST1716_TheMasseuselcci
{
    public int Massage(int[] nums)
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

/// 递归，会超时
public class MST1716_TheMasseuselcci_0
{
    public int Massage(int[] nums)
    {
        if (nums == null || nums.Length == 0) return 0;

        return MassageMax(nums, 0);
    }

    private int MassageMax(int[] nums, int startIndex)
    {
        if (startIndex >= nums.Length) return 0;

        return Math.Max(nums[startIndex] + MassageMax(nums, startIndex + 2), MassageMax(nums, startIndex + 1));
    }
}
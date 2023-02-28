using System;

namespace LeetCode.Problems.Easy;

/// 递减元素使数组呈锯齿状
/// https://leetcode.cn/problems/decrease-elements-to-make-array-zigzag/
public class P1144_MdecreaseElementsToMakeArrayZigzag
{
    public int MovesToMakeZigzag(int[] nums)
    {
        return Math.Min(Helper(nums, 0), Helper(nums, 1));
    }

    public int Helper(int[] nums, int start)
    {
        int ans = 0;
        for (int i = start; i < nums.Length; i += 2)
        {
            var delta = 0;
            if (i > 0)
            {
                delta = Math.Max(delta, nums[i] - nums[i - 1] + 1);
            }

            if (i < nums.Length - 1)
            {
                delta = Math.Max(delta, nums[i] - nums[i + 1] + 1);
            }

            ans += delta;
        }

        return ans;
    }
}
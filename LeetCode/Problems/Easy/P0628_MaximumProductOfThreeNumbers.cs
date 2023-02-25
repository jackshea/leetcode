using System;

namespace LeetCode.Problems.Easy;

/// 三个数的最大乘积
/// https://leetcode-cn.com/problems/maximum-product-of-three-numbers/
public class P0628_MaximumProductOfThreeNumbers
{
    public int MaximumProduct(int[] nums)
    {
        Array.Sort(nums);
        var n = nums.Length;
        return Math.Max(nums[0] * nums[1] * nums[n - 1], nums[n - 3] * nums[n - 2] * nums[n - 1]);
    }
}
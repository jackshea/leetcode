using System;

namespace LeetCode
{
    /// 三个数的最大乘积
    /// https://leetcode-cn.com/problems/maximum-product-of-three-numbers/
    public class P0628_MaximumProductOfThreeNumbers
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length - 1] * Math.Max(nums[0] * nums[1], nums[nums.Length - 3] * nums[nums.Length - 2]);
        }
    }
}
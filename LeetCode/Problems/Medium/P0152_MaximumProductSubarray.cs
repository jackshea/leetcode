using System;

namespace LeetCode.Problems.Medium;

/// 乘积最大子序列
/// https://leetcode-cn.com/problems/maximum-product-subarray/
public class P0152_MaximumProductSubarray
{
    public int MaxProduct(int[] nums)
    {
        var ans = nums[0];
        var curMin = nums[0];
        var curMax = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num < 0)
            {
                var temp = curMax;
                curMax = curMin;
                curMin = temp;
            }

            curMax = Math.Max(curMax * num, num);
            curMin = Math.Min(curMin * num, num);

            if (curMax > ans) ans = curMax;
        }

        return ans;
    }
}
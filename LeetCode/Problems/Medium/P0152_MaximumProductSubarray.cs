using System;

namespace LeetCode.Problems.Medium
{
    /// 乘积最大子序列
    /// https://leetcode-cn.com/problems/maximum-product-subarray/
    public class P0152_MaximumProductSubarray
    {
        public int MaxProduct(int[] nums)
        {
            int ans = nums[0];
            int curMin = nums[0];
            int curMax = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int num = nums[i];

                if (num < 0)
                {
                    int temp = curMax;
                    curMax = curMin;
                    curMin = temp;
                }

                curMax = Math.Max(curMax * num, num);
                curMin = Math.Min(curMin * num, num);

                if (curMax > ans)
                {
                    ans = curMax;
                }
            }

            return ans;
        }
    }
}
using System;

namespace LeetCode.Problems.Medium
{
    /// 乘积为正数的最长子数组长度
    /// https://leetcode-cn.com/problems/maximum-length-of-subarray-with-positive-product/
    public class P1567_MaximumLengthOfSubarrayWithPositiveProduct
    {
        public int GetMaxLen(int[] nums)
        {
            int ans = 0, positive = 0, negative = 0;
            foreach (var num in nums)
            {
                if (num > 0)
                {
                    positive++;
                    if (negative > 0)
                    {
                        negative++;
                    }
                }
                else if (num < 0)
                {
                    int temp = positive;
                    positive = negative > 0 ? negative + 1 : 0;
                    negative = temp + 1;
                }
                else
                {
                    positive = 0;
                    negative = 0;
                }

                ans = Math.Max(ans, positive);
            }

            return ans;
        }
    }
}
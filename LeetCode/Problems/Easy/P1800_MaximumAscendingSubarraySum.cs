using System;

namespace LeetCode.Problems.Easy
{
    /// 最大升序子数组和
    /// https://leetcode-cn.com/problems/maximum-ascending-subarray-sum/
    public class P1800_MaximumAscendingSubarraySum
    {
        public int MaxAscendingSum(int[] nums)
        {
            int sum = nums[0];
            int ans = sum;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    sum += nums[i];
                }
                else
                {
                    sum = nums[i];
                }

                ans = Math.Max(ans, sum);
            }

            return ans;
        }
    }
}
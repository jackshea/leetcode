using System;

namespace LeetCode.Problems.Easy
{
    /// 连续数列
    /// https://leetcode-cn.com/problems/contiguous-sequence-lcci/
    public class MST1617
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = 0, maxSum = int.MinValue;
            foreach (var num in nums)
            {
                sum += num;
                maxSum = Math.Max(maxSum, sum);
                if (sum < 0)
                {
                    sum = 0;
                }
            }

            return maxSum;
        }
    }
}
using System;

namespace LeetCode.Contest.Biweekly.C045
{
    /// 任意子数组和的绝对值的最大值
    /// https://leetcode-cn.com/contest/biweekly-contest-45/problems/maximum-absolute-sum-of-any-subarray/
    public class P5658
    {
        public int MaxAbsoluteSum(int[] nums)
        {
            int min = 0, max = 0;
            int positiveSum = 0, negativeSum = 0;
            foreach (var num in nums)
            {
                positiveSum += num;
                if (positiveSum > max)
                {
                    max = positiveSum;
                }

                if (positiveSum < 0)
                {
                    positiveSum = 0;
                }
                negativeSum += num;
                if (negativeSum < min)
                {
                    min = negativeSum;
                }
                if (negativeSum > 0)
                {
                    negativeSum = 0;
                }
            }

            return Math.Max(Math.Abs(min), max);
        }
    }
}
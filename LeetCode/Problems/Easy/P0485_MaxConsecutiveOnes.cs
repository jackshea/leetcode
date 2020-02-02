using System;

namespace LeetCode.Problems
{
    /// 最大连续1的个数
    /// https://leetcode-cn.com/problems/max-consecutive-ones/
    public class P0485_MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int maxConsecutiveOnes = 0;
            int consecutiveOnes = 0;
            foreach (var num in nums)
            {
                if (num == 1)
                {
                    consecutiveOnes++;
                    maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, consecutiveOnes);
                }
                else
                {
                    consecutiveOnes = 0;
                }
            }

            return maxConsecutiveOnes;
        }
    }
}
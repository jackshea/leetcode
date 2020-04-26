﻿namespace LeetCode.Problems.Medium
{
    /// 只出现一次的数字 III
    /// https://leetcode-cn.com/problems/single-number-iii/
    public class P0260_SingleNumberIII
    {
        public int[] SingleNumber(int[] nums)
        {
            int bitmask = 0;
            foreach (var num in nums)
            {
                bitmask ^= num;
            }

            int diff = bitmask & (-bitmask);
            int x = 0;
            foreach (var num in nums)
            {
                if ((num & diff) != 0)
                {
                    x ^= num;
                }
            }

            return new[] { x, x ^ bitmask };
        }
    }
}
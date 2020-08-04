using System;

namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 61. 扑克牌中的顺子
    /// https://leetcode-cn.com/problems/bu-ke-pai-zhong-de-shun-zi-lcof/
    public class Offer61
    {
        public bool IsStraight(int[] nums)
        {
            int min = 14;
            foreach (var num in nums)
            {
                if (num == 0)
                {
                    continue;
                }

                min = Math.Min(min, num);
            }

            // 全为0的情况
            if (min == 14)
            {
                return true;
            }

            bool[] check = new bool[5];
            foreach (var num in nums)
            {
                if (num == 0)
                {
                    continue;
                }

                var diff = num - min;
                if (diff >= 5)
                {
                    return false;
                }
                if (check[diff])
                {
                    return false;
                }

                check[diff] = true;
            }

            return true;
        }
    }
}
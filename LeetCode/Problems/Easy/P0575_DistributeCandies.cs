using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 分糖果
    /// https://leetcode-cn.com/problems/distribute-candies
    public class P0575_DistributeCandies
    {
        public int DistributeCandies(int[] candies)
        {
            HashSet<int> kinds = new HashSet<int>();
            foreach (var candy in candies)
            {
                kinds.Add(candy);
            }

            return Math.Min(kinds.Count, candies.Length / 2);
        }
    }
}
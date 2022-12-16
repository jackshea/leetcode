using System;

namespace LeetCode.Problems.Medium
{
    /// 构成特定和需要添加的最少元素
    /// https://leetcode.cn/problems/minimum-elements-to-add-to-form-a-given-sum/
    public class P1785_MinimumElementsToAddToFormAGivenSum
    {
        public int MinElements(int[] nums, int limit, int goal)
        {
            long sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }

            return (int)Math.Ceiling(1.0 * Math.Abs(goal - sum) / limit);
        }
    }
}
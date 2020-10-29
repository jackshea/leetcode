using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 132模式
    /// https://leetcode-cn.com/problems/132-pattern/
    public class P0456_132Pattern
    {
        public bool Find132pattern(int[] nums)
        {
            int[] minArray = new int[nums.Length];
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                min = Math.Min(min, nums[i]);
                minArray[i] = min;
            }

            Stack<int> stack = new Stack<int>();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] <= minArray[i])
                {
                    continue;
                }

                while (stack.Count > 0 && stack.Peek() <= minArray[i])
                {
                    stack.Pop();
                }

                if (stack.Count > 0 && stack.Peek() < nums[i])
                {
                    return true;
                }

                stack.Push(nums[i]);
            }

            return false;
        }
    }
}
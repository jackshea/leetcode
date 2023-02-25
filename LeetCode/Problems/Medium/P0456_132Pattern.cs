using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 132模式
/// https://leetcode-cn.com/problems/132-pattern/
public class P0456_132Pattern
{
    public bool Find132pattern(int[] nums)
    {
        var minArray = new int[nums.Length];
        var min = int.MaxValue;
        for (var i = 0; i < nums.Length; i++)
        {
            min = Math.Min(min, nums[i]);
            minArray[i] = min;
        }

        var stack = new Stack<int>();
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] <= minArray[i]) continue;

            while (stack.Count > 0 && stack.Peek() <= minArray[i]) stack.Pop();

            if (stack.Count > 0 && stack.Peek() < nums[i]) return true;

            stack.Push(nums[i]);
        }

        return false;
    }
}
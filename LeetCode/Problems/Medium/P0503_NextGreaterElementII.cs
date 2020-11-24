using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 下一个更大元素 II
    /// https://leetcode-cn.com/problems/next-greater-element-ii/
    public class P0503_NextGreaterElementII
    {
        public int[] NextGreaterElements(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return nums;
            }

            Stack<int> stack = new Stack<int>();
            int[] ans = new int[nums.Length];
            for (int i = 2 * nums.Length - 1; i >= 0; i--)
            {
                var modI = i % nums.Length;
                var num = nums[modI];

                while (stack.Count > 0 && stack.Peek() <= num)
                {
                    stack.Pop();
                }

                if (stack.Count == 0)
                {
                    ans[modI] = -1;
                }
                else
                {
                    ans[modI] = stack.Peek();
                }
                stack.Push(num);
            }

            return ans;
        }
    }
}
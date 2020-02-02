using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy
{
    /// 数组的度
    /// https://leetcode-cn.com/problems/degree-of-an-array/
    public class P0697_DegreeOfAnArray
    {
        public int FindShortestSubArray(int[] nums)
        {
            var count = new Dictionary<int, int>();
            var left = new Dictionary<int, int>();
            var right = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }

                if (!left.ContainsKey(num))
                {
                    left[num] = i;
                }

                right[num] = i;
            }

            int ans = nums.Length;
            int degree = count.Values.Max();
            foreach (var num in nums)
            {
                if (count[num] == degree)
                {
                    ans = Math.Min(ans, right[num] - left[num] + 1);
                }
            }

            return ans;
        }
    }
}
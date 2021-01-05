using System;

namespace LeetCode.Problems.Medium
{
    /// 数组嵌套
    /// https://leetcode-cn.com/problems/array-nesting/
    public class P0565_ArrayNesting
    {
        public int ArrayNesting(int[] nums)
        {
            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    continue;
                }

                int len = 0;
                int jumpIdx = i;
                while (nums[jumpIdx] >= 0)
                {
                    int next = nums[jumpIdx];
                    nums[jumpIdx] = -1;
                    jumpIdx = next;
                    len++;
                }

                ans = Math.Max(ans, len);
                if (ans >= nums.Length / 2)
                {
                    break;
                }
            }

            return ans;
        }
    }
}
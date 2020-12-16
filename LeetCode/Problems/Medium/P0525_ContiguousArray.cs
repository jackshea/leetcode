using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 连续数组
    /// https://leetcode-cn.com/problems/contiguous-array/
    public class P0525_ContiguousArray
    {
        public int FindMaxLength(int[] nums)
        {
            int cnt = 0; // 1++  0--
            Dictionary<int, int> cnt2idx = new Dictionary<int, int>();
            cnt2idx[0] = -1;
            int ans = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (num == 1)
                {
                    cnt++;
                }
                else
                {
                    cnt--;
                }

                if (cnt2idx.ContainsKey(cnt))
                {
                    ans = Math.Max(ans, i - cnt2idx[cnt]);
                }
                else
                {
                    cnt2idx[cnt] = i;
                }
            }

            return ans;
        }
    }
}
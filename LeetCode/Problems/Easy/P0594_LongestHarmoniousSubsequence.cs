using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 最长和谐子序列
    /// https://leetcode-cn.com/problems/longest-harmonious-subsequence/
    public class P0594_LongestHarmoniousSubsequence
    {
        public int FindLHS(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic[num] = 1;
                }
            }

            int result = 0;
            foreach (var key in dic.Keys)
            {
                if (dic.ContainsKey(key + 1))
                {
                    result = Math.Max(result, dic[key] + dic[key + 1]);
                }
            }

            return result;
        }
    }
}
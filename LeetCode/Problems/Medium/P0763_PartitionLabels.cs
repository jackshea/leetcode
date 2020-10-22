using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 划分字母区间
    /// https://leetcode-cn.com/problems/partition-labels/
    public class P0763_PartitionLabels
    {
        public IList<int> PartitionLabels(string S)
        {
            IList<int> ans = new List<int>();

            int[] end = new int[26];
            for (var i = 0; i < S.Length; i++)
            {
                end[S[i] - 'a'] = i;
            }

            int left = 0, right = 0;
            while (right < S.Length)
            {
                int len = 0;
                while (left <= right)
                {
                    right = Math.Max(right, end[S[left] - 'a']);
                    left++;
                    len++;
                }

                ans.Add(len);
                right++;
            }

            return ans;
        }
    }
}
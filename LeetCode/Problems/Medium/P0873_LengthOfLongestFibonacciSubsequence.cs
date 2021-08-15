using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 最长的斐波那契子序列的长度
    /// https://leetcode-cn.com/problems/length-of-longest-fibonacci-subsequence/
    public class P0873_LengthOfLongestFibonacciSubsequence
    {
        public int LenLongestFibSubseq(int[] arr)
        {
            int n = arr.Length;
            Dictionary<int, int> index = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                index[arr[i]] = i;
            }

            Dictionary<int, int> longest = new Dictionary<int, int>();
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (index.TryGetValue(arr[i] - arr[j], out var idx) && idx < j)
                    {
                        int cand = 3;
                        if (longest.TryGetValue(idx * n + j, out var last))
                        {
                            cand = last + 1;
                        }

                        longest[j * n + i] = cand;
                        ans = Math.Max(ans, cand);
                    }
                }
            }

            return ans >= 3 ? ans : 0;
        }
    }
}
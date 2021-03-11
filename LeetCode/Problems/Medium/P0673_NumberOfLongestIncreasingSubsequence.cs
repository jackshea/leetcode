using System;
using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 最长递增子序列的个数
    /// https://leetcode-cn.com/problems/number-of-longest-increasing-subsequence/
    public class P0673_NumberOfLongestIncreasingSubsequence
    {
        public int FindNumberOfLIS(int[] nums)
        {
            var n = nums.Length;
            if (n <= 1)
            {
                return n;
            }
            int[] lens = new int[n];
            int[] counts = new int[n];
            Array.Fill(counts, 1);

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        if (lens[j] >= lens[i])
                        {
                            lens[i] = lens[j] + 1;
                            counts[i] = counts[j];
                        }
                        else
                        {
                            counts[i] += counts[j];
                        }
                    }
                }
            }

            int longest = lens.Max();
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (lens[i]==longest)
                {
                    ans += counts[i];
                }
            }

            return ans;
        }
    }
}
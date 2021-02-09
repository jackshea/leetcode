using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// K 个不同整数的子数组
    /// https://leetcode-cn.com/problems/subarrays-with-k-different-integers/
    public class P0992_SubarraysWithKDifferentIntegers
    {
        public int SubarraysWithKDistinct(int[] A, int K)
        {
            return MostSubarraysWithKDistinct(A, K) - MostSubarraysWithKDistinct(A, K - 1);
        }

        /// 最多 K 个不同整数的子数组
        public int MostSubarraysWithKDistinct(int[] A, int K)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            int ans = 0, diff = 0;
            int left = 0, right = 0;
            while (right < A.Length)
            {
                if (freq.TryGetValue(A[right], out var cnt) && cnt != 0)
                {
                    freq[A[right]] = cnt + 1;
                }
                else
                {
                    freq[A[right]] = 1;
                    diff++;
                }

                right++;
                while (diff > K)
                {
                    freq[A[left]]--;
                    if (freq[A[left]] == 0)
                    {
                        diff--;
                    }

                    left++;
                }

                ans += right - left;
            }

            return ans;
        }
    }
}
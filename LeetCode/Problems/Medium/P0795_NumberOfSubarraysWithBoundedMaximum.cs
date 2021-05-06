using System;

namespace LeetCode.Problems.Medium
{
    /// 区间子数组个数
    /// https://leetcode-cn.com/problems/number-of-subarrays-with-bounded-maximum/
    public class P0795_NumberOfSubarraysWithBoundedMaximum
    {
        public int NumSubarrayBoundedMax(int[] A, int L, int R)
        {
            return Count(A, R) - Count(A, L - 1);
        }

        public int Count(int[] A, int bound)
        {
            int ans = 0, cur = 0;
            foreach (var num in A)
            {
                if (num <= bound)
                {
                    cur++;
                    ans += cur;
                }
                else
                {
                    cur = 0;
                }
            }

            return ans;
        }
    }
}
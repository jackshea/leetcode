using System;

namespace LeetCode.Problems.Medium
{
    /// 最大连续1的个数 III
    /// https://leetcode-cn.com/problems/max-consecutive-ones-iii/
    public class P1004_MaxConsecutiveOnesIII
    {
        public int LongestOnes(int[] A, int K)
        {
            int ans = 0;
            int left = 0, right = 0;
            int zeroCnt = 0;
            while (right < A.Length)
            {
                if (A[right] == 0)
                {
                    zeroCnt++;
                    while (zeroCnt > K)
                    {
                        if (A[left++] == 0)
                        {
                            zeroCnt--;
                        }
                    }
                }

                right++;
                ans = Math.Max(ans, right - left);
            }

            return ans;
        }
    }


    public class P1004_MaxConsecutiveOnesIII_1
    {
        public int LongestOnes(int[] A, int K)
        {
            int l = 0, r = 0;
            while (r < A.Length)
            {
                if (A[r++] == 0) K--;
                if (K < 0 && A[l++] == 0) K++;
            }
            return r - l;
        }
    }
}
using System;

namespace LeetCode.Problems.Medium
{
    /// 数组中的最长山脉
    /// https://leetcode-cn.com/problems/longest-mountain-in-array/
    public class P0845_LongestMountainInArray
    {
        public int LongestMountain(int[] A)
        {
            if (A.Length < 3)
            {
                return 0;
            }
            int ans = 0;
            int start = -1;
            int state = 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                var diff = A[i + 1] - A[i];
                if (diff > 0)
                {
                    if (state != 1)
                    {
                        start = i;
                    }

                    state = 1;
                }
                else if (diff < 0)
                {
                    if (start != -1)
                    {
                        ans = Math.Max(ans, i + 2 - start);
                    }
                    state = -1;
                }
                else
                {
                    state = 0;
                    start = -1;
                }
            }
            if (ans < 3)
            {
                return 0;
            }
            return ans;
        }
    }
}
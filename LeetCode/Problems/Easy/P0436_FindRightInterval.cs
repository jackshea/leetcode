using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 寻找右区间
    /// https://leetcode-cn.com/problems/find-right-interval/
    public class P0436_FindRightInterval
    {
        public int[] FindRightInterval(int[][] intervals)
        {
            int[][] start2Index = new int[intervals.Length][];
            for (var i = 0; i < intervals.Length; i++)
            {
                start2Index[i] = new[] { intervals[i][0], i };
            }
            Array.Sort(start2Index, (a, b) => a[0].CompareTo(b[0]));
            int[] ans = new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
            {
                int end = intervals[i][1];
                int left = 0, right = intervals.Length;
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (start2Index[mid][0] < end)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }
                }
                if (right == intervals.Length)
                {
                    ans[i] = -1;
                }
                else
                {
                    ans[i] = start2Index[right][1];
                }
            }

            return ans;
        }
    }
}
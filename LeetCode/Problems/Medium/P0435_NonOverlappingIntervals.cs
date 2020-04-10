using System;

namespace LeetCode.Problems.Medium
{
    /// 无重叠区间
    /// https://leetcode-cn.com/problems/non-overlapping-intervals/
    public class P0435_NonOverlappingIntervals
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            if (intervals.Length <= 1)
            {
                return 0;
            }
            // 按结束端点从小到大排序
            Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
            int count = 1; // 不相交的相间数
            int end = intervals[0][1];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] >= end)
                {
                    count++;
                    end = intervals[i][1];
                }
            }

            return intervals.Length - count;
        }
    }
}
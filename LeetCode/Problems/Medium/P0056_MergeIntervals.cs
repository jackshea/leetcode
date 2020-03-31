using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCode.Problems.Medium
{
    /// 合并区间
    /// https://leetcode-cn.com/problems/merge-intervals/
    public class P0056_MergeIntervals
    {
        public int[][] Merge(int[][] intervals)
        {
            if (intervals == null || intervals.Length <= 1)
            {
                return intervals;
            }
            List<int[]> ans = new List<int[]>();
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            int[] pre = intervals[0];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (pre[1] < intervals[i][0])
                {
                    ans.Add(new int[] { pre[0], pre[1] });
                    pre = intervals[i];
                }
                else
                {
                    if (pre[1] < intervals[i][1])
                    {
                        pre[1] = intervals[i][1];
                    }
                }
            }

            if (ans.Count == 0 || ans[ans.Count - 1][0] != pre[0])
            {
                ans.Add(pre);
            }

            return ans.ToArray();
        }
    }
}
using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// 插入区间
/// https://leetcode-cn.com/problems/insert-interval/
public class P0057_InsertInterval
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var ans = new List<int[]>();
        if (intervals.Length == 0) return new[] { newInterval };

        var start = newInterval[0];
        var end = newInterval[1];
        var add = false;
        for (var i = 0; i < intervals.Length; i++)
        {
            if (intervals[i][1] < newInterval[0])
            {
                ans.Add(intervals[i]);
                continue;
            }

            start = Math.Min(start, intervals[i][0]);

            if (intervals[i][0] <= newInterval[1])
            {
                end = Math.Max(end, intervals[i][1]);
            }
            else
            {
                if (!add)
                {
                    ans.Add(new[] { start, end });
                    add = true;
                }

                ans.Add(intervals[i]);
            }
        }

        if (!add) ans.Add(new[] { start, end });

        return ans.ToArray();
    }
}
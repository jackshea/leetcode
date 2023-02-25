using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 我的日程安排表 I
/// https://leetcode-cn.com/problems/my-calendar-i/
public class MyCalendar
{
    private readonly List<int[]> ranges = new();

    public bool Book(int start, int end)
    {
        foreach (var range in ranges)
            if (range[0] < end && range[1] > start)
                return false;
        ranges.Add(new[] { start, end });
        return true;
    }
}
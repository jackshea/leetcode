using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 我的日程安排表 II
    /// https://leetcode-cn.com/problems/my-calendar-ii/
    public class MyCalendarTwo
    {
        private List<int[]> book1 = new List<int[]>();
        private List<int[]> book2 = new List<int[]>();

        public MyCalendarTwo()
        {

        }

        public bool Book(int start, int end)
        {
            foreach (var b2 in book2)
            {
                if (start < b2[1] && end > b2[0])
                {
                    return false;
                }
            }

            foreach (var b1 in book1)
            {
                if (start < b1[1] && end > b1[0])
                {
                    book2.Add(new[] { Math.Max(start, b1[0]), Math.Min(end, b1[1]) });
                }
            }
            book1.Add(new[] { start, end });
            return true;
        }
    }
}
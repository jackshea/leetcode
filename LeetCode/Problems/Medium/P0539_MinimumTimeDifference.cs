using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 最小时间差
    /// https://leetcode-cn.com/problems/minimum-time-difference/
    public class P0539_MinimumTimeDifference
    {
        public int FindMinDifference(IList<string> timePoints)
        {
            int minutesInADay = 24 * 60;
            if (timePoints.Count > minutesInADay)
            {
                return 0;
            }
            List<int> minutes = new List<int>(timePoints.Count);
            foreach (var timePoint in timePoints)
            {
                minutes.Add(ToMinute(timePoint));
            }
            minutes.Sort();
            int minDiff = minutesInADay;
            for (int i = 1; i < minutes.Count; i++)
            {
                minDiff = Math.Min(minDiff, minutes[i] - minutes[i - 1]);
                if (minDiff == 0)
                {
                    return 0;
                }
            }
            minDiff = Math.Min(minDiff, minutes[0] + minutesInADay - minutes[minutes.Count - 1]);
            return minDiff;
        }

        private int ToMinute(string timePoint)
        {
            var split = timePoint.Split(':');
            return int.Parse(split[0]) * 60 + int.Parse(split[1]);
        }
    }
}
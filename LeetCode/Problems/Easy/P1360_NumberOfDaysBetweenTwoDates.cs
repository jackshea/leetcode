using System;

namespace LeetCode.Problems.Easy
{
    /// 日期之间隔几天
    /// https://leetcode-cn.com/problems/number-of-days-between-two-dates/
    public class P1360_NumberOfDaysBetweenTwoDates
    {
        private int sinceYear = 1971;
        private int[] monthDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public int DaysBetweenDates(string date1, string date2)
        {
            return Math.Abs(Days(date1) - Days(date2));
        }

        public int Days(string date)
        {
            var dateString = date.Split('-');
            int year = int.Parse(dateString[0]);
            int month = int.Parse(dateString[1]);
            int day = int.Parse(dateString[2]);
            int days = 0;
            for (int y = sinceYear; y < year; y++)
            {
                days += IsLeapYear(y) ? 366 : 365;
            }

            for (int i = 1; i < month; i++)
            {
                days += monthDays[i];
            }

            days += day;
            // 闰年且超过2-29号的情况
            if (month >= 3 && IsLeapYear(year))
            {
                days++;
            }

            return days;
        }

        public bool IsLeapYear(int year)
        {
            if (year % 100 == 0)
            {
                return year % 400 == 0;
            }
            else
            {
                return year % 4 == 0;
            }
        }
    }
}
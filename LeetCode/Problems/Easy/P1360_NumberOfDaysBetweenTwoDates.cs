using System;

namespace LeetCode.Problems.Easy;

/// 日期之间隔几天
/// https://leetcode-cn.com/problems/number-of-days-between-two-dates/
public class P1360_NumberOfDaysBetweenTwoDates
{
    private readonly int[] monthDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    private readonly int sinceYear = 1971;

    public int DaysBetweenDates(string date1, string date2)
    {
        return Math.Abs(Days(date1) - Days(date2));
    }

    public int Days(string date)
    {
        var dateString = date.Split('-');
        var year = int.Parse(dateString[0]);
        var month = int.Parse(dateString[1]);
        var day = int.Parse(dateString[2]);
        var days = 0;
        for (var y = sinceYear; y < year; y++) days += IsLeapYear(y) ? 366 : 365;

        for (var i = 1; i < month; i++) days += monthDays[i];

        days += day;
        // 闰年且超过2-29号的情况
        if (month >= 3 && IsLeapYear(year)) days++;

        return days;
    }

    public bool IsLeapYear(int year)
    {
        if (year % 100 == 0)
            return year % 400 == 0;
        return year % 4 == 0;
    }
}
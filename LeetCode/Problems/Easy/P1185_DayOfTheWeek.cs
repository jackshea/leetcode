﻿namespace LeetCode.Problems.Easy;

/// 一周中的第几天
/// https://leetcode-cn.com/problems/day-of-the-week/
public class P1185_DayOfTheWeek
{
    //1971-1-1 星期五
    public string DayOfTheWeek(int day, int month, int year)
    {
        var days = 0;
        for (var i = 1971; i < year; i++)
            if (IsLeapYear(i))
                days += 366;
            else
                days += 365;

        days += DayOfYear(day, month, year);
        string[] weekNames = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        return weekNames[(days + 4) % 7];
    }

    private bool IsLeapYear(int year)
    {
        return (year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
    }

    public int DayOfYear(int day, int month, int year)
    {
        var leapYear = IsLeapYear(year) ? 1 : 0;
        int[] days = { 0, 31, 28 + leapYear, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        var dayOfYear = 0;
        for (var i = 0; i < month; i++) dayOfYear += days[i];

        dayOfYear += day;
        return dayOfYear;
    }
}
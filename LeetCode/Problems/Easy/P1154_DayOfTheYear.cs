namespace LeetCode.Problems.Easy;

/// 一年中的第几天
/// https://leetcode-cn.com/problems/day-of-the-year/
public class P1154_DayOfTheYear
{
    public int DayOfYear(string date)
    {
        var d = date.Split('-');
        var year = int.Parse(d[0]);
        var month = int.Parse(d[1]);
        var day = int.Parse(d[2]);
        var leapYear = 0;
        if ((year % 100 != 0 && year % 4 == 0) || (year % 100 == 0 && year % 400 == 0)) leapYear = 1;

        int[] days = { 0, 31, 28 + leapYear, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        var dayOfYear = 0;
        for (var i = 0; i < month; i++) dayOfYear += days[i];

        dayOfYear += day;
        return dayOfYear;
    }
}
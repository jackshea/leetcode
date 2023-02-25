using System;

namespace LeetCode.Problems.Easy;

/// 去掉最低工资和最高工资后的工资平均值
/// https://leetcode-cn.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/
public class P1491_AverageSalaryExcludingTheMinimumAndMaximumSalary
{
    public double Average(int[] salary)
    {
        var max = int.MinValue;
        var min = int.MaxValue;
        var sum = 0;
        foreach (var s in salary)
        {
            max = Math.Max(max, s);
            min = Math.Min(min, s);
            sum += s;
        }

        return 1.0 * (sum - max - min) / (salary.Length - 2);
    }
}
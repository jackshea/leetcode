using System;
using System.Text;

namespace LeetCode.Problems.Easy;

/// 七进制数
/// https://leetcode-cn.com/problems/base-7/
public class P0504_Base7
{
    public string ConvertToBase7(int num)
    {
        if (num == 0) return "0";

        var isNegative = num < 0;
        var absNum = Math.Abs(num);
        var sb = new StringBuilder();

        while (absNum != 0)
        {
            sb.Append(absNum % 7);
            absNum /= 7;
        }

        var result = new StringBuilder();

        if (isNegative) result.Append('-');

        for (var i = sb.Length - 1; i >= 0; i--) result.Append(sb[i]);

        return result.ToString();
    }
}
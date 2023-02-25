using System;
using System.Text;

namespace LeetCode.Problems.Easy;

/// 整数反转
/// https://leetcode-cn.com/problems/reverse-integer/description/
public class P0007_ReverseInteger
{
    public int Reverse(int x)
    {
        var sign = Math.Sign(x);
        var s = "0";
        try
        {
            s = Math.Abs(x).ToString();
        }
        catch
        {
        }

        var sb = new StringBuilder();
        for (var i = s.Length - 1; i >= 0; i--) sb.Append(s[i]);

        var reverseNum = 0;
        try
        {
            reverseNum = Convert.ToInt32(sb.ToString());
        }
        catch
        {
            // ignored
        }

        return sign * reverseNum;
    }
}
using System;

namespace LeetCode.Problems.Easy;

/// 整理字符串
/// https://leetcode-cn.com/problems/make-the-string-great/
public class P1544_MakeTheStringGreat
{
    public string MakeGood(string s)
    {
        var cs = new char[s.Length];
        var length = 0;
        foreach (var c in s)
        {
            if (length > 0 && Math.Abs(cs[length - 1] - c) == 32)
            {
                length--;
                continue;
            }

            cs[length++] = c;
        }

        if (length <= 0)
            return string.Empty;
        return new string(cs, 0, length);
    }
}
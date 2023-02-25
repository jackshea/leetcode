using System;

namespace LeetCode.Contest.Weekly.C228;

/// 生成交替二进制字符串的最少操作数
/// https://leetcode-cn.com/contest/weekly-contest-228/problems/minimum-changes-to-make-alternating-binary-string/
public class P5676
{
    public int MinOperations(string s)
    {
        var n = s.Length;
        var mark = '1';
        var diffCnt = 0;
        foreach (var c in s)
        {
            if (c != mark) diffCnt++;

            mark = mark == '1' ? '0' : '1';
        }

        return Math.Min(diffCnt, n - diffCnt);
    }
}
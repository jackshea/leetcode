using System;
using System.Text;

namespace LeetCode.Problems.Easy;

/// 二进制求和
/// https://leetcode-cn.com/problems/add-binary/description/
public class P0067_AddBinary
{
    public string AddBinary(string a, string b)
    {
        var result = '0';
        var carry = '0';
        var length = Math.Max(a.Length, b.Length);
        var sb = new StringBuilder();

        for (var i = 0; i < length; i++)
        {
            var indexA = a.Length - i - 1;
            var indexB = b.Length - i - 1;
            var ca = indexA >= 0 ? a[indexA] : '0';
            var cb = indexB >= 0 ? b[indexB] : '0';
            Add(ca, cb, carry, ref result, ref carry);
            sb.Append(result);
        }

        if (carry == '1') sb.Append(carry);

        var stringSb = sb.ToString();

        var sbResult = new StringBuilder();

        for (var i = stringSb.Length - 1; i >= 0; i--) sbResult.Append(stringSb[i]);

        return sbResult.ToString();
    }

    private void Add(char a, char b, char c, ref char result, ref char carry)
    {
        var d = a - '0' + b - '0' + c - '0';
        result = (char)(d % 2 + '0');
        carry = (char)(d / 2 + '0');
    }
}
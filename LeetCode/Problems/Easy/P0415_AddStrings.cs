﻿using System.Linq;
using System.Text;

namespace LeetCode.Problems.Easy;

/// 字符串相加
/// https://leetcode-cn.com/problems/add-strings/
public class P0415_AddStrings
{
    public string AddStrings(string num1, string num2)
    {
        var sb = new StringBuilder();

        var carry = 0;
        for (int index1 = num1.Length - 1, index2 = num2.Length - 1; index1 >= 0 || index2 >= 0; index1--, index2--)
        {
            var a = 0;
            if (index1 >= 0) a = num1[index1] - '0';

            var b = 0;
            if (index2 >= 0) b = num2[index2] - '0';

            var result = a + b + carry;
            if (result > 9)
            {
                carry = 1;
                result -= 10;
            }
            else
            {
                carry = 0;
            }

            sb.Append(result);
        }

        if (carry == 1) sb.Append(1);

        return new string(sb.ToString().Reverse().ToArray());
    }
}
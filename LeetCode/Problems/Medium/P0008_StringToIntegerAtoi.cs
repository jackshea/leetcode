using System;

namespace LeetCode.Problems.Medium
{
    /// 字符串转换整数 (atoi)
    /// https://leetcode-cn.com/problems/string-to-integer-atoi/
    public class P0008_StringToIntegerAtoi
    {
        public int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            long ans = 0;
            int sign = 1;
            int index = 0;
            while (index < str.Length && str[index] == ' ')
            {
                index++;
            }

            if (index == str.Length)
            {
                return 0;
            }

            if (str[index] == '-')
            {
                sign = -1;
                index++;
            }
            else if (str[index] == '+')
            {
                index++;
            }
            else if (char.IsDigit(str[index]))
            {
            }
            else
            {
                return 0;
            }

            for (; index < str.Length; index++)
            {
                if (char.IsDigit(str[index]))
                {
                    ans = ans * 10 + (str[index] - '0');
                    if (ans > Int32.MaxValue + 1L)
                    {
                        ans = Int32.MaxValue + 1L;
                    }
                }
                else
                {
                    break;
                }
            }

            ans *= sign;
            if (ans > Int32.MaxValue)
            {
                return Int32.MaxValue;
            }
            else if (ans < Int32.MinValue)
            {
                return Int32.MinValue;
            }
            else
            {
                return (int)ans;
            }
        }
    }
}
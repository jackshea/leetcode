using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 分数加减运算
/// https://leetcode-cn.com/problems/fraction-addition-and-subtraction/
public class P0592_FractionAdditionAndSubtraction
{
    public string FractionAddition(string expression)
    {
        var sign = 1;
        var num = 0;
        var den = 1;
        var nums = new List<int>();
        var dens = new List<int>();
        foreach (var e in expression)
            if (e == '-')
            {
                if (num != 0)
                {
                    dens.Add(num);
                    den *= num;
                    num = 0;
                }

                sign = -1;
            }
            else if (e == '+')
            {
                if (num != 0)
                {
                    dens.Add(num);
                    den *= num;
                    num = 0;
                }

                sign = 1;
            }
            else if ('0' <= e && e <= '9')
            {
                num = num * 10 + (e - '0');
            }
            else if (e == '/')
            {
                nums.Add(num * sign);
                num = 0;
                sign = 1;
            }

        dens.Add(num);
        den *= num;
        num = 0;
        for (var i = 0; i < nums.Count; i++) num += den / dens[i] * nums[i];

        var gcd = Math.Abs(GCD(num, den));
        den /= gcd;
        num /= gcd;
        return $"{num}/{den}";
    }

    public int GCD(int a, int b)
    {
        var mod = a % b;
        if (mod == 0) return b;

        return GCD(b, mod);
    }
}
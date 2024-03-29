﻿using System;

namespace LeetCode.Problems.Easy;

/// 平方数之和
/// https://leetcode-cn.com/problems/sum-of-square-numbers/
public class P0633_SumOfSquareNumbers
{
    public bool JudgeSquareSum(int c)
    {
        var i = 0;
        var j = (int)Math.Sqrt(c);
        while (i <= j)
        {
            var sum = i * i + j * j;
            if (sum < c)
                i++;
            else if (sum > c)
                j--;
            else
                return true;
        }

        return false;
    }
}
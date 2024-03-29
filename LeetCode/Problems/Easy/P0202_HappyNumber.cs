﻿using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 快乐数
/// https://leetcode-cn.com/problems/happy-number/submissions/
public class P0202_HappyNumber
{
    public bool IsHappy(int n)
    {
        var results = new HashSet<int>();
        results.Add(n);
        while (n != 1)
        {
            n = Next(n);
            if (results.Contains(n)) return false;

            results.Add(n);
        }

        return true;
    }

    public int Next(int n)
    {
        var result = 0;
        var temp = 0;
        while (n > 0)
        {
            temp = n % 10;
            result += temp * temp;
            n = n / 10;
        }

        return result;
    }
}
﻿using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 回文数
/// https://leetcode-cn.com/problems/palindrome-number/description/
public class P0009_PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        if (x >= 0 && x <= 9) return true;

        var tempX = x;

        var numbers = new List<int>();
        while (tempX > 0)
        {
            numbers.Add(tempX % 10);
            tempX /= 10;
        }

        for (var i = 0; i < numbers.Count / 2; i++)
            if (numbers[i] != numbers[numbers.Count - 1 - i])
                return false;

        return true;
    }
}
﻿namespace LeetCode.Problems.Easy;

/// 各位相加
/// https://leetcode-cn.com/problems/add-digits/
public class P0258_AddDigits
{
    public int AddDigits(int num)
    {
        while (num >= 10)
        {
            var temp = num;
            num = 0;
            while (temp > 0)
            {
                num += temp % 10;
                temp /= 10;
            }
        }

        return num;
    }
}
﻿namespace LeetCode.Problems.Easy;

/// 统计位数为偶数的数字
/// https://leetcode-cn.com/problems/find-numbers-with-even-number-of-digits/
public class P1295_FindNumbersWithEvenNumberOfDigits
{
    public int FindNumbers(int[] nums)
    {
        var ans = 0;
        foreach (var num in nums)
        {
            var count = 0;
            var n = num;
            while (n > 0)
            {
                count++;
                n /= 10;
            }

            if (count % 2 == 0) ans++;
        }

        return ans;
    }
}
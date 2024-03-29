﻿namespace LeetCode.Problems.Medium;

/// 统计字典序元音字符串的数目
/// https://leetcode-cn.com/contest/weekly-contest-213/problems/count-sorted-vowel-strings/
public class P5555
{
    public int CountVowelStrings(int n)
    {
        int[] dp = { 1, 1, 1, 1, 1 };
        var sum = 5;
        for (var i = 2; i <= n; i++)
        {
            sum = 1;
            for (var j = 1; j < dp.Length; j++)
            {
                dp[j] += dp[j - 1];
                sum += dp[j];
            }
        }

        return sum;
    }
}
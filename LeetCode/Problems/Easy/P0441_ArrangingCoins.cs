﻿namespace LeetCode.Problems.Easy;

/// 排列硬币
/// https://leetcode-cn.com/problems/arranging-coins/
public class P0441_ArrangingCoins
{
    public int ArrangeCoins(int n)
    {
        var count = 0;
        for (var i = 1; i <= n; i++)
        {
            n -= i;
            count++;
        }

        return count;
    }
}
﻿using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 二进制手表
/// https://leetcode-cn.com/problems/binary-watch/
public class P0401_BinaryWatch
{
    public IList<string> ReadBinaryWatch(int num)
    {
        var resList = new List<string>();
        for (var i = 0; i < 12; ++i)
        for (var j = 0; j < 60; ++j)
            if (HammingWeight((i << 6) | j) == num)
                resList.Add(i + ":" + (j > 9 ? "" : "0") + j);
        return resList;
    }

    public int HammingWeight(int n)
    {
        var count = 0;
        while (n != 0)
        {
            if (n % 2 == 1) count++;

            n = n >> 1;
        }

        return count;
    }
}
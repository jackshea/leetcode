﻿using System;

namespace LeetCode.Problems.Easy;

/// 按键持续时间最长的键
/// https://leetcode-cn.com/contest/weekly-contest-212/problems/slowest-key/
public class P5546
{
    public char SlowestKey(int[] releaseTimes, string keysPressed)
    {
        var key = new int[26];
        for (var i = 0; i < releaseTimes.Length; i++)
        {
            var c = keysPressed[i] - 'a';
            if (i == 0)
            {
                key[c] = releaseTimes[i];
                continue;
            }

            key[c] = Math.Max(key[c], releaseTimes[i] - releaseTimes[i - 1]);
        }

        var max = 0;
        var ans = 'a';
        for (var i = 0; i < 26; i++)
            if (max <= key[i])
            {
                max = key[i];
                ans = (char)('a' + i);
            }

        return ans;
    }
}
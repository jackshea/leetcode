﻿using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 重排字符形成目标字符串
/// https://leetcode.cn/problems/rearrange-characters-to-make-target-string/
public class P2287_RearrangeCharactersToMakeTargetString
{
    public int RearrangeCharacters(string s, string target)
    {
        var sDic = new Dictionary<char, int>();
        var targetDic = new Dictionary<char, int>();
        foreach (var c in s)
        {
            sDic.TryAdd(c, 0);
            sDic[c]++;
        }

        foreach (var c in target)
        {
            targetDic.TryAdd(c, 0);
            targetDic[c]++;
        }

        var ans = s.Length;
        var count = 0;
        foreach (var kvp in targetDic)
            if (sDic.TryGetValue(kvp.Key, out count))
                ans = Math.Min(ans, count / kvp.Value);

        return ans;
    }
}
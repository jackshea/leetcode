﻿using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 分割平衡字符串
/// https://leetcode-cn.com/problems/split-a-string-in-balanced-strings/
public class P1221_SplitAStringInBalancedStrings
{
    public int BalancedStringSplit(string s)
    {
        var stack = new Stack<char>();
        var ans = 0;
        foreach (var c in s)
        {
            if (stack.Count == 0)
            {
                stack.Push(c);
                continue;
            }

            if (stack.Peek() != c)
            {
                stack.Pop();
                if (stack.Count == 0) ans++;
            }
            else
            {
                stack.Push(c);
            }
        }

        return ans;
    }
}
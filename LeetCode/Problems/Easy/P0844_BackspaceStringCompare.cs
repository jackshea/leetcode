﻿using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 比较含退格的字符串
/// https://leetcode-cn.com/problems/backspace-string-compare/
public class P0844_BackspaceStringCompare
{
    public bool BackspaceCompare(string S, string T)
    {
        var s = Convert(S);
        var t = Convert(T);
        if (s.Count != t.Count) return false;

        while (s.Count != 0)
            if (s.Pop() != t.Pop())
                return false;

        return true;
    }

    private Stack<char> Convert(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
            if (c == '#')
            {
                if (stack.Count > 0) stack.Pop();
            }
            else
            {
                stack.Push(c);
            }

        return stack;
    }
}
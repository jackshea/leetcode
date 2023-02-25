using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 括号的分数
/// https://leetcode-cn.com/problems/score-of-parentheses/
public class P0856_ScoreOfParentheses
{
    public int ScoreOfParentheses(string s)
    {
        var stack = new Stack<int>();
        stack.Push(0);
        foreach (var c in s)
            if (c == '(')
            {
                stack.Push(0);
            }
            else
            {
                var a = stack.Pop();
                var b = stack.Pop();
                stack.Push(b + Math.Max(a * 2, 1));
            }

        return stack.Pop();
    }
}
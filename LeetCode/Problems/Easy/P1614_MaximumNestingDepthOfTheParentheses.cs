using System;

namespace LeetCode.Problems.Easy;

/// 括号的最大嵌套深度
/// https://leetcode-cn.com/contest/weekly-contest-210/problems/maximum-nesting-depth-of-the-parentheses/
public class P1614_MaximumNestingDepthOfTheParentheses
{
    public int MaxDepth(string s)
    {
        var ans = 0;
        var cur = 0;
        foreach (var c in s)
        {
            if (c == '(')
            {
                cur++;
                ans = Math.Max(ans, cur);
            }

            if (c == ')') cur--;
        }

        return ans;
    }
}
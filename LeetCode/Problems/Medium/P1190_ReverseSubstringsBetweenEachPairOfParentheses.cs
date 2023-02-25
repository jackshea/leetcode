using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 反转每对括号间的子串
/// https://leetcode-cn.com/problems/reverse-substrings-between-each-pair-of-parentheses/
public class P1190_ReverseSubstringsBetweenEachPairOfParentheses
{
    public string ReverseParentheses(string s)
    {
        var charArray = s.ToCharArray();
        var stack = new Stack<int>();
        for (var i = 0; i < charArray.Length; i++)
            if (charArray[i] == '(')
            {
                stack.Push(i);
            }
            else if (charArray[i] == ')')
            {
                var last = stack.Pop();
                Reverse(charArray, last + 1, i - 1);
            }

        // 去括号
        var len = 0;
        for (var i = 0; i < charArray.Length; i++)
            if (charArray[i] != '(' && charArray[i] != ')')
                charArray[len++] = charArray[i];

        return new string(charArray, 0, len);
    }

    public void Reverse(char[] charArray, int start, int end)
    {
        while (start < end)
        {
            var tmp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = tmp;
            start++;
            end--;
        }
    }
}
using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 有效的括号
    /// https://leetcode-cn.com/problems/valid-parentheses/description/
    public class P0020_ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                    continue;
                }

                if (stack.Count == 0)
                {
                    return false;
                }

                if (c == ')' && stack.Pop() != '(')
                {
                    return false;
                }

                if (c == ']' && stack.Pop() != '[')
                {
                    return false;
                }

                if (c == '}' && stack.Pop() != '{')
                {
                    return false;
                }
            }

            return stack.Count != 0;
        }
    }
}
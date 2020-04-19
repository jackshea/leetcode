using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 基本计算器 II
    /// https://leetcode-cn.com/problems/basic-calculator-ii/
    public class P0227_BasicCalculatorII
    {
        public int Calculate(string s)
        {
            Stack<int> stack = new Stack<int>();
            int start = 0;
            while (start < s.Length)
            {
                switch (s[start])
                {
                    case ' ':
                        start++;
                        break;
                    case '+':
                        start++;
                        stack.Push(readInt(s, ref start));
                        break;
                    case '-':
                        start++;
                        stack.Push(-readInt(s, ref start));
                        break;
                    case '*':
                        start++;
                        stack.Push(stack.Pop() * readInt(s, ref start));
                        break;
                    case '/':
                        start++;
                        stack.Push(stack.Pop() / readInt(s, ref start));
                        break;
                    default:
                        stack.Push(readInt(s, ref start));
                        break;
                }
            }

            int ans = 0;
            while (stack.Count != 0)
            {
                ans += stack.Pop();
            }
            return ans;
        }

        private int readInt(string s, ref int start)
        {
            int ans = 0;
            while (start < s.Length && s[start] == ' ')
            {
                start++;
            }

            while (start < s.Length && s[start] >= '0' && s[start] <= '9')
            {
                ans = ans * 10 + (s[start] - '0');
                start++;
            }

            return ans;
        }
    }
}
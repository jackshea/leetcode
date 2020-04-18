using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 逆波兰表达式求值
    /// https://leetcode-cn.com/problems/evaluate-reverse-polish-notation/
    public class P0150_EvaluateReversePolishNotation
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();
            foreach (var token in tokens)
            {
                switch (token)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        int num1 = stack.Pop();
                        int num2 = stack.Pop();
                        stack.Push(Operate(num2, num1, token));
                        break;
                    default:
                        int num = int.Parse(token);
                        stack.Push(num);
                        break;
                }
            }

            return stack.Pop();
        }

        public int Operate(int a, int b, string operate)
        {
            int ans = 0;
            switch (operate)
            {
                case "+":
                    ans = a + b;
                    break;
                case "-":
                    ans = a - b;
                    break;
                case "*":
                    ans = a * b;
                    break;
                case "/":
                    ans = a / b;
                    break;
            }

            return ans;
        }
    }
}
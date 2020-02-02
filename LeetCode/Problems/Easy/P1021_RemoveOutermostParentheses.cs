using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    /// 删除最外层的括号
    /// https://leetcode-cn.com/problems/remove-outermost-parentheses/
    public class P1021_RemoveOutermostParentheses
    {
        public string RemoveOuterParentheses(string S)
        {
            StringBuilder ans = new StringBuilder();
            var stack = new Stack<char>();
            var last = 0;
            for (var i = 0; i < S.Length; i++)
            {
                var c = S[i];
                switch (c)
                {
                    case '(':
                        stack.Push(c);
                        break;
                    case ')':
                        stack.Pop();
                        if (stack.Count == 0)
                        {
                            ans.Append(S.Substring(last + 1, i - last - 1));
                            last = i + 1;
                        }

                        break;
                }
            }

            return ans.ToString();
        }
    }
}
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 为运算表达式设计优先级
    /// https://leetcode-cn.com/problems/different-ways-to-add-parentheses/
    public class P0241_DifferentWaysToAddParentheses
    {
        public IList<int> DiffWaysToCompute(string input)
        {
            IList<int> ans = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == '+' || c == '-' || c == '*')
                {
                    IList<int> left = DiffWaysToCompute(input.Substring(0, i));
                    IList<int> right = DiffWaysToCompute(input.Substring(i + 1));
                    foreach (var l in left)
                    {
                        foreach (var r in right)
                        {
                            switch (c)
                            {
                                case '+': ans.Add(l + r); break;
                                case '-': ans.Add(l - r); break;
                                case '*': ans.Add(l * r); break;
                            }
                        }
                    }
                }
            }

            if (ans.Count == 0)
            {
                ans.Add(int.Parse(input));
            }

            return ans;
        }
    }
}
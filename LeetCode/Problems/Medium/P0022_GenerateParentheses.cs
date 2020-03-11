using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 括号生成
    /// https://leetcode-cn.com/problems/generate-parentheses/
    public class P0022_GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> ans = new List<string>();
            if (n <= 0)
            {
                ans.Add(string.Empty);
                return ans;
            }

            for (int i = 0; i < n; i++)
            {
                foreach (var left in GenerateParenthesis(i))
                {
                    foreach (var right in GenerateParenthesis(n - i - 1))
                    {
                        ans.Add($"({left}){right}");
                    }
                }
            }

            return ans;
        }
    }
}
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 括号
    /// https://leetcode-cn.com/problems/bracket-lcci/
    public class MST0809
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> ans = new List<string>();
            if (n == 0)
            {
                ans.Add(string.Empty);
                return ans;
            }

            for (int i = 0; i < n; i++)
            {
                IList<string> left = GenerateParenthesis(i);
                foreach (var l in left)
                {
                    IList<string> right = GenerateParenthesis(n - i - 1);
                    foreach (var r in right)
                    {
                        ans.Add($"({l}){r}");
                    }
                }
            }

            return ans;
        }
    }
}
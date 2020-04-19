namespace LeetCode.Problems.Medium
{
    /// 基本计算器
    /// https://leetcode-cn.com/problems/basic-calculator/
    public class P0224_BasicCalculator
    {
        private int start = 0;
        public int Calculate(string s)
        {
            int ans = 0;
            int num = 0;
            int sign = 1;
            while (start < s.Length)
            {
                var c = s[start++];
                if (c == ' ')
                {
                }
                else if (char.IsDigit(c))
                {
                    num = num * 10 + (c - '0');
                }
                else if (c == '+')
                {
                    ans += num * sign;
                    sign = 1;
                    num = 0;
                }
                else if (c == '-')
                {
                    ans += num * sign;
                    sign = -1;
                    num = 0;
                }
                else if (c == '(')
                {
                    ans += Calculate(s) * sign;
                    num = 0;
                }
                else if (c == ')')
                {
                    break;
                }
            }
            ans += num * sign;
            return ans;
        }
    }
}
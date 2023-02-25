namespace LeetCode.Problems.Hard;

/// 基本计算器
/// https://leetcode-cn.com/problems/basic-calculator/
public class P0224_BasicCalculator
{
    private int start;

    public int Calculate(string s)
    {
        var ans = 0;
        var num = 0;
        var sign = 1;
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
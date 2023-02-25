namespace LeetCode.Problems.Medium;

/// 有效的括号字符串
/// https://leetcode-cn.com/problems/valid-parenthesis-string/
public class P0678_ValidParenthesisString
{
    public bool CheckValidString(string s)
    {
        // 未配对的左括号的数量区间[min, max]
        int min = 0, max = 0;
        foreach (var c in s)
        {
            switch (c)
            {
                case '(':
                    min++;
                    max++;
                    break;
                case '*':
                    if (min > 0) min--;
                    max++;
                    break;
                case ')':
                    if (min > 0) min--;
                    max--;
                    break;
            }

            if (max < 0) return false;
        }

        return min == 0;
    }
}
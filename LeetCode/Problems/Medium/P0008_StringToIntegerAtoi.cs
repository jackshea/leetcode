namespace LeetCode.Problems.Medium;

/// 字符串转换整数 (atoi)
/// https://leetcode-cn.com/problems/string-to-integer-atoi/
public class P0008_StringToIntegerAtoi
{
    public int MyAtoi(string str)
    {
        if (string.IsNullOrEmpty(str)) return 0;

        long ans = 0;
        var sign = 1;
        var index = 0;
        while (index < str.Length && str[index] == ' ') index++;

        if (index == str.Length) return 0;

        if (str[index] == '-')
        {
            sign = -1;
            index++;
        }
        else if (str[index] == '+')
        {
            index++;
        }
        else if (char.IsDigit(str[index]))
        {
        }
        else
        {
            return 0;
        }

        for (; index < str.Length; index++)
            if (char.IsDigit(str[index]))
            {
                ans = ans * 10 + (str[index] - '0');
                if (ans > int.MaxValue + 1L) ans = int.MaxValue + 1L;
            }
            else
            {
                break;
            }

        ans *= sign;
        if (ans > int.MaxValue)
            return int.MaxValue;
        if (ans < int.MinValue)
            return int.MinValue;
        return (int)ans;
    }
}
using System.Text;

namespace LeetCode.Problems.Medium;

/// 字符串相乘
/// https://leetcode-cn.com/problems/multiply-strings/
public class P0043_MultiplyStrings
{
    public string Multiply(string num1, string num2)
    {
        if (string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num2) || num1 == "0" || num2 == "0") return "0";

        var res = new int[num1.Length + num2.Length - 1];
        for (var i = 0; i < num1.Length; i++)
        for (var j = 0; j < num2.Length; j++)
            res[i + j] += (num1[i] - '0') * (num2[j] - '0');

        for (var i = res.Length - 1; i >= 1; i--)
        {
            res[i - 1] += res[i] / 10;
            res[i] %= 10;
        }

        var carry = res[0] / 10;
        res[0] %= 10;
        var ans = new StringBuilder();
        if (carry != 0) ans.Append(carry);

        foreach (var digit in res) ans.Append(digit);

        return ans.ToString();
    }
}
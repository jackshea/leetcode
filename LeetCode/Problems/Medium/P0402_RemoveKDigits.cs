using System.Text;

namespace LeetCode.Problems.Medium;

/// 移掉K位数字
/// https://leetcode-cn.com/problems/remove-k-digits/
public class P0402_RemoveKDigits
{
    public string RemoveKdigits(string num, int k)
    {
        if (num.Length == k) return "0";
        var s = new StringBuilder(num);
        for (var i = 0; i < k; i++)
        {
            var idx = 0;
            for (var j = 1; j < s.Length && s[j] >= s[j - 1]; j++) idx = j;
            s.Remove(idx, 1);
            while (s.Length > 1 && s[0] == '0') s.Remove(0, 1);
        }

        return s.ToString();
    }
}
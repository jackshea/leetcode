using System.Text;

namespace LeetCode.Problems.Medium;

/// 隐藏个人信息
/// https://leetcode-cn.com/problems/masking-personal-information/
public class P0831_MaskingPersonalInformation
{
    public string MaskPII(string s)
    {
        if (s.Contains('@'))
        {
            var names = s.Split('@', '.');
            names[0] = names[0][0] + "*****" + names[0][names[0].Length - 1];
            return $"{names[0]}@{names[1]}.{names[2]}".ToLower();
        }

        var sb = new StringBuilder();
        foreach (var c in s)
        {
            if (!char.IsDigit(c)) continue;

            sb.Append(c);
        }

        var pre = new StringBuilder();
        if (sb.Length > 10)
        {
            pre.Append('+');
            for (var i = 0; i < sb.Length - 10; i++) pre.Append('*');

            pre.Append('-');
        }

        return pre + "***-***-" + sb.ToString().Substring(sb.Length - 4, 4);
    }
}
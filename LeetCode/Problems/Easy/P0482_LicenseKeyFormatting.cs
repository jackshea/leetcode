using System.Text;

namespace LeetCode.Problems.Easy;

/// 密钥格式化
/// https://leetcode-cn.com/problems/license-key-formatting/
public class P0482_LicenseKeyFormatting
{
    public string LicenseKeyFormatting(string S, int K)
    {
        var sb = new StringBuilder();
        var count = 0;
        for (var i = S.Length - 1; i >= 0; i--)
        {
            var c = S[i];
            if (c == '-') continue;


            if (char.IsLower(c)) c = char.ToUpper(c);

            sb.Append(c);

            if (++count % K == 0) sb.Append('-');
        }

        var sb2 = new StringBuilder();
        for (var i = sb.Length - 1; i >= 0; i--)
        {
            if (i == sb.Length - 1 && sb[sb.Length - 1] == '-') continue;

            sb2.Append(sb[i]);
        }

        return sb2.ToString();
    }
}
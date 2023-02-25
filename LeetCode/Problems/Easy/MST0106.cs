using System.Text;

namespace LeetCode.Problems.Easy;

/// 面试题 01.06. 字符串压缩
/// https://leetcode-cn.com/problems/compress-string-lcci/
public class MST0106
{
    public string CompressString(string S)
    {
        var sb = new StringBuilder();
        var count = 1;
        for (var i = 0; i < S.Length; i++)
            if (i == S.Length - 1 || S[i] != S[i + 1])
            {
                sb.Append(S[i]).Append(count);
                count = 1;
            }
            else
            {
                count++;
            }

        if (sb.Length < S.Length) return sb.ToString();

        return S;
    }
}
using System.Text;

namespace LeetCode.Problems.Medium;

/// 字符串解码
/// https://leetcode-cn.com/problems/decode-string/
public class P0394_DecodeString
{
    public string DecodeString(string s)
    {
        var index = 0;
        return DecodeString(s, ref index);
    }

    public string DecodeString(string s, ref int index)
    {
        var ans = new StringBuilder();
        var times = 0;
        while (index < s.Length)
        {
            var c = s[index];
            if (char.IsLetter(c))
            {
                ans.Append(c);
                index++;
            }
            else if (char.IsDigit(c))
            {
                times = times * 10 + (c - '0');
                index++;
            }
            else if (c == '[')
            {
                ++index;
                ans.Append(Times(DecodeString(s, ref index), times));
                times = 0;
            }
            else if (c == ']')
            {
                index++;
                break;
            }
        }

        return ans.ToString();
    }

    private string Times(string s, int times)
    {
        if (times <= 1) return s;

        var sb = new StringBuilder();
        for (var i = 0; i < times; i++) sb.Append(s);

        return sb.ToString();
    }
}
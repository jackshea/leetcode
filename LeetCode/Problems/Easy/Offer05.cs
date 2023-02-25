using System.Text;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 05. 替换空格
/// https://leetcode-cn.com/problems/ti-huan-kong-ge-lcof/
public class Offer05
{
    public string ReplaceSpace(string s)
    {
        var sb = new StringBuilder();
        foreach (var c in s)
            if (c == ' ')
                sb.Append("%20");
            else
                sb.Append(c);

        return sb.ToString();
    }
}
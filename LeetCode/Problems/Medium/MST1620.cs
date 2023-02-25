using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Medium;

/// T9键盘
/// https://leetcode-cn.com/problems/t9-lcci/
public class MST1620
{
    private readonly string letter2Num = "22233344455566677778889999";

    public IList<string> GetValidT9Words(string num, string[] words)
    {
        IList<string> ans = new List<string>();
        foreach (var word in words)
            if (WordToNum(word) == num)
                ans.Add(word);

        return ans;
    }

    private string WordToNum(string word)
    {
        var sb = new StringBuilder();
        foreach (var c in word) sb.Append(letter2Num[c - 'a']);

        return sb.ToString();
    }
}
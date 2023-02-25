using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 无重复字符串的排列组合
/// https://leetcode-cn.com/problems/permutation-i-lcci/
public class MST0807
{
    private readonly List<string> ans = new();

    public string[] Permutation(string S)
    {
        Backtrack(0, S.ToCharArray());
        return ans.ToArray();
    }

    private void Backtrack(int start, char[] chars)
    {
        if (start == chars.Length)
        {
            ans.Add(new string(chars));
            return;
        }

        for (var i = start; i < chars.Length; i++)
        {
            Swap(chars, start, i);
            Backtrack(start + 1, chars);
            Swap(chars, start, i);
        }
    }

    private void Swap(char[] chars, int i, int j)
    {
        var temp = chars[i];
        chars[i] = chars[j];
        chars[j] = temp;
    }
}
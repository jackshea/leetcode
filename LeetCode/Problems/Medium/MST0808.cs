using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 有重复字符串的排列组合
/// https://leetcode-cn.com/problems/permutation-ii-lcci/
public class MST0808
{
    private readonly List<string> ans = new();

    public string[] Permutation(string S)
    {
        var charArray = S.ToCharArray();
        Array.Sort(charArray);
        Backtrack(0, charArray);
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
            if (!CanSwap(chars, start, i)) continue;
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

    /// 为了去重，可以交换的条件是 chars[begin...end-1]没有出现过等于 chars[end]的元素。
    private bool CanSwap(char[] chars, int begin, int end)
    {
        for (var k = begin; k < end; k++)
            if (chars[k] == chars[end])
                return false;

        return true;
    }
}
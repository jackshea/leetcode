using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Medium;

/// 剑指 Offer 38. 字符串的排列
/// https://leetcode-cn.com/problems/zi-fu-chuan-de-pai-lie-lcof/
public class Offer38
{
    private readonly List<string> ans = new();
    private bool[] visited;

    public string[] Permutation(string s)
    {
        var charArray = s.ToCharArray();
        Array.Sort(charArray);
        visited = new bool[s.Length];
        DFS(charArray, 0, new StringBuilder());
        return ans.ToArray();
    }

    public void DFS(char[] chars, int start, StringBuilder pre)
    {
        if (start == chars.Length)
        {
            ans.Add(pre.ToString());
            return;
        }

        for (var j = 0; j < chars.Length; j++)
        {
            if (visited[j] || (j > 0 && !visited[j - 1] && chars[j - 1] == chars[j])) continue;

            visited[j] = true;
            pre.Append(chars[j]);
            DFS(chars, start + 1, pre);
            pre.Length--;
            visited[j] = false;
        }
    }
}
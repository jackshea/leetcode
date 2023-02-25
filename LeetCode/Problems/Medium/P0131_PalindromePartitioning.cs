using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 分割回文串
/// https://leetcode-cn.com/problems/palindrome-partitioning/
public class P0131_PalindromePartitioning
{
    private readonly IList<IList<string>> ans = new List<IList<string>>();
    private string s;

    public IList<IList<string>> Partition(string s)
    {
        this.s = s;
        DFS(0, new List<string>());
        return ans;
    }

    private void DFS(int start, IList<string> pre)
    {
        if (start == s.Length)
        {
            ans.Add(new List<string>(pre));
            return;
        }

        for (var i = start; i < s.Length; i++)
        {
            if (!IsPalindrome(s, start, i)) continue;

            var sub = s.Substring(start, i - start + 1);
            pre.Add(sub);
            DFS(i + 1, pre);
            pre.RemoveAt(pre.Count - 1);
        }
    }

    private bool IsPalindrome(string s, int start, int end)
    {
        while (start < end)
            if (s[start++] != s[end--])
                return false;

        return true;
    }
}
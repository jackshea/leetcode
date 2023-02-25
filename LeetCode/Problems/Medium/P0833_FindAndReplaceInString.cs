using System;
using System.Text;

namespace LeetCode.Problems.Medium;

/// 字符串中的查找与替换
/// https://leetcode-cn.com/problems/find-and-replace-in-string/
public class P0833_FindAndReplaceInString
{
    public string FindReplaceString(string s, int[] indices, string[] sources, string[] targets)
    {
        var n = s.Length;
        var matchIndex = new int[n];
        Array.Fill(matchIndex, -1);
        for (var i = 0; i < sources.Length; i++)
        {
            var check = true;
            for (var j = 0; j < sources[i].Length; j++)
                if (sources[i][j] != s[indices[i] + j])
                {
                    check = false;
                    break;
                }

            if (check) matchIndex[indices[i]] = i;
        }

        var sb = new StringBuilder();
        var index = 0;
        while (index < n)
            if (matchIndex[index] >= 0)
            {
                sb.Append(targets[matchIndex[index]]);
                index += sources[matchIndex[index]].Length;
            }
            else
            {
                sb.Append(s[index++]);
            }

        return sb.ToString();
    }
}
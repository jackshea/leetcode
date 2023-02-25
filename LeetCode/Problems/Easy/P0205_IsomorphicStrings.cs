using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 同构字符串
/// https://leetcode-cn.com/problems/isomorphic-strings/
public class P0205_IsomorphicStrings
{
    public bool IsIsomorphic(string s, string t)
    {
        var dic = new Dictionary<char, char>();
        var mappedChars = new HashSet<char>();
        for (var i = 0; i < s.Length; i++)
            if (dic.ContainsKey(s[i]))
            {
                if (dic[s[i]] != t[i]) return false;
            }
            else
            {
                if (mappedChars.Contains(t[i])) return false;
                dic[s[i]] = t[i];
                mappedChars.Add(t[i]);
            }

        return true;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problems.Medium;

/// 根据字符出现频率排序
/// https://leetcode-cn.com/problems/sort-characters-by-frequency/
public class P0451_SortCharactersByFrequency
{
    public string FrequencySort(string s)
    {
        var cs = s.ToCharArray();
        var dic = new Dictionary<char, int>();
        foreach (var c in cs)
        {
            dic.TryGetValue(c, out var cnt);
            dic[c] = cnt + 1;
        }

        var keys = dic.Keys.ToList();
        keys.Sort((a, b) => -dic[a].CompareTo(dic[b]));
        var sb = new StringBuilder();
        foreach (var key in keys) sb.Append(key, dic[key]);

        return sb.ToString();
    }

    public string FrequencySort1(string s)
    {
        var cs = s.ToCharArray();
        var dic = new Dictionary<char, int>();
        foreach (var c in cs)
        {
            dic.TryGetValue(c, out var cnt);
            dic[c] = cnt + 1;
        }

        Array.Sort(cs, (a, b) =>
        {
            var f = dic[a].CompareTo(dic[b]);
            if (f == 0) return -a.CompareTo(b);

            return f;
        });
        return new string(cs);
    }
}
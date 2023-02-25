using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 模糊坐标
/// https://leetcode-cn.com/problems/ambiguous-coordinates/
public class P0816_AmbiguousCoordinates
{
    public IList<string> AmbiguousCoordinates(string s)
    {
        IList<string> ans = new List<string>();
        s = s.Substring(1, s.Length - 2);
        for (var i = 1; i < s.Length; i++)
        {
            var left = CanBeNumbers(s.Substring(0, i));
            var right = CanBeNumbers(s.Substring(i, s.Length - i));
            if (left.Count == 0 || right.Count == 0) continue;

            foreach (var l in left)
            foreach (var r in right)
                ans.Add($"({l}, {r})");
        }

        return ans;
    }

    private List<string> CanBeNumbers(string s)
    {
        var numbers = new List<string>();
        if (s.Length <= 1)
        {
            numbers.Add(s);
            return numbers;
        }

        if (s.StartsWith('0'))
        {
            if (!s.EndsWith('0')) numbers.Add(s.Insert(1, "."));
            return numbers;
        }

        numbers.Add(s);
        if (s.EndsWith('0')) return numbers;

        for (var i = 1; i < s.Length; i++) numbers.Add(s.Insert(i, "."));

        return numbers;
    }
}
using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 单词规律
/// https://leetcode-cn.com/problems/word-pattern/
public class P0290_WordPattern
{
    public bool WordPattern(string pattern, string str)
    {
        var targets = str.Split(' ');
        if (pattern.Length != targets.Length) return false;

        var pattern2Target = new Dictionary<char, string>();
        var existString = new HashSet<string>();

        for (var i = 0; i < pattern.Length; i++)
        {
            var c = pattern[i];
            var target = targets[i];
            if (pattern2Target.ContainsKey(c))
            {
                if (pattern2Target[c] != target) return false;
            }
            else
            {
                if (existString.Contains(target)) return false;
                pattern2Target[c] = target;
                existString.Add(target);
            }
        }

        return true;
    }
}
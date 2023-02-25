using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 统计一致字符串的数目
/// https://leetcode-cn.com/problems/count-the-number-of-consistent-strings/
public class P1684_CountTheNumberOfConsistentStrings
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        var charSet = new HashSet<char>();
        foreach (var c in allowed) charSet.Add(c);

        var ans = 0;
        foreach (var word in words)
        {
            var check = true;
            foreach (var c in word)
                if (!charSet.Contains(c))
                {
                    check = false;
                    break;
                }

            if (check) ans++;
        }

        return ans;
    }
}
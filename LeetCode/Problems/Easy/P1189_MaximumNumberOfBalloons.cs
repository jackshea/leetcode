using System.Linq;

namespace LeetCode.Problems.Easy;

/// “气球” 的最大数量
/// https://leetcode-cn.com/problems/maximum-number-of-balloons/
public class P1189_MaximumNumberOfBalloons
{
    public int MaxNumberOfBalloons(string text)
    {
        var cc = new int[26];
        foreach (var c in text) cc[c - 'a']++;

        return new[] { cc[0], cc[1], cc['l' - 'a'] / 2, cc['o' - 'a'] / 2, cc['n' - 'a'] }.Min();
    }
}
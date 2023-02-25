using System.Linq;

namespace LeetCode.Problems.Easy;

/// 判断字符串的两半是否相似
/// https://leetcode-cn.com/problems/determine-if-string-halves-are-alike/
public class P1704_DetermineIfStringHalvesAreAlike
{
    public bool HalvesAreAlike(string s)
    {
        var aeiou = "aeiouAEIOU".ToHashSet();
        var vowelCount = 0;
        var halfLen = s.Length / 2;
        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (!aeiou.Contains(c)) continue;
            if (i < halfLen)
            {
                vowelCount++;
            }
            else
            {
                vowelCount--;
                if (vowelCount < 0) return false;
            }
        }

        return vowelCount == 0;
    }
}
namespace LeetCode.Problems.Medium;

/// 字符串的排列
/// https://leetcode-cn.com/problems/permutation-in-string/
public class P0567_PermutationInString
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        var s1Map = new int[26];
        var s2Map = new int[26];
        for (var i = 0; i < s1.Length; i++)
        {
            s1Map[s1[i] - 'a']++;
            s2Map[s2[i] - 'a']++;
        }

        if (Check(s1Map, s2Map)) return true;

        for (var i = 0; i < s2.Length - s1.Length; i++)
        {
            s2Map[s2[i] - 'a']--;
            s2Map[s2[i + s1.Length] - 'a']++;
            if (Check(s1Map, s2Map)) return true;
        }

        return false;
    }

    private bool Check(int[] s1Map, int[] s2Map)
    {
        for (var i = 0; i < s1Map.Length; i++)
            if (s1Map[i] != s2Map[i])
                return false;

        return true;
    }
}
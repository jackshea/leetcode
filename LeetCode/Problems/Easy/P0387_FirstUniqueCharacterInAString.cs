namespace LeetCode.Problems.Easy;

/// 字符串中的第一个唯一字符
/// https://leetcode-cn.com/problems/first-unique-character-in-a-string/
public class P0387_FirstUniqueCharacterInAString
{
    public int FirstUniqChar(string s)
    {
        var charCount = new int[26];
        foreach (var c in s) charCount[c - 'a']++;

        for (var i = 0; i < s.Length; i++)
            if (charCount[s[i] - 'a'] == 1)
                return i;

        return -1;
    }
}
namespace LeetCode.Problems.Easy;

/// 重新分配字符使所有字符串都相等
/// https://leetcode-cn.com/problems/redistribute-characters-to-make-all-strings-equal/
public class P1897_RedistributeCharactersToMakeAllStringsEqual
{
    public bool MakeEqual(string[] words)
    {
        var freq = new int[26];
        foreach (var word in words)
        foreach (var c in word)
            freq[c - 'a']++;

        var n = words.Length;
        foreach (var f in freq)
            if (f % n != 0)
                return false;

        return true;
    }
}
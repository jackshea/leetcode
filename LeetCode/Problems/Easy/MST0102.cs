namespace LeetCode.Problems.Easy;

/// 面试题 01.02. 判定是否互为字符重排
/// https://leetcode-cn.com/problems/check-permutation-lcci/
public class MST0102
{
    public bool CheckPermutation(string s1, string s2)
    {
        var chars1 = CountChars(s1);
        var chars2 = CountChars(s2);
        for (var i = 0; i < chars1.Length; i++)
            if (chars1[i] != chars2[i])
                return false;

        return true;
    }

    private int[] CountChars(string s)
    {
        var chars = new int[60];
        foreach (var c in s) chars[c - 'A']++;

        return chars;
    }
}
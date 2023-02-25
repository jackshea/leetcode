namespace LeetCode.Problems.Easy;

/// 找不同
/// https://leetcode-cn.com/problems/find-the-difference/
public class P0389_FindTheDifference
{
    public char FindTheDifference(string s, string t)
    {
        var sumS = 0;
        foreach (var c in s) sumS += c;

        var sumT = 0;
        foreach (var c in t) sumT += c;

        return (char)(sumT - sumS);
    }
}
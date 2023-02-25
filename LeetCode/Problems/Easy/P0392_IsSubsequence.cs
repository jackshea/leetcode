namespace LeetCode.Problems.Easy;

/// 判断子序列
/// https://leetcode-cn.com/problems/is-subsequence/
public class P0392_IsSubsequence
{
    public bool IsSubsequence(string s, string t)
    {
        var si = 0;
        if (s.Length == 0) return true;
        for (var i = 0; i < t.Length; i++)
            if (t[i] == s[si])
            {
                si++;
                if (si == s.Length) return true;
            }

        return false;
    }
}
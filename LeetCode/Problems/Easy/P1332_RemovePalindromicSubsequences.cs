namespace LeetCode.Problems.Easy;

/// 删除回文子序列
/// https://leetcode-cn.com/problems/remove-palindromic-subsequences/
public class P1332_RemovePalindromicSubsequences
{
    public int RemovePalindromeSub(string s)
    {
        if (s.Length == 0) return 0;

        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right]) return 2;

            left++;
            right--;
        }

        return 1;
    }
}
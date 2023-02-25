namespace LeetCode.Problems.Easy;

/// 验证回文字符串 Ⅱ
/// https://leetcode-cn.com/problems/valid-palindrome-ii/comments/
public class P0680_ValidPalindromeII
{
    public bool ValidPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right]) return ValidPalindrome(s, left + 1, right) || ValidPalindrome(s, left, right - 1);

            left++;
            right--;
        }

        return true;
    }

    private bool ValidPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right]) return false;

            left++;
            right--;
        }

        return true;
    }
}
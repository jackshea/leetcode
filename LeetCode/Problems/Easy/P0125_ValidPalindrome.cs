namespace LeetCode.Problems.Easy;

/// 验证回文串
/// https://leetcode-cn.com/problems/valid-palindrome/description/
public class P0125_ValidPalindrome
{
    public bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;
        while (left < right)
        {
            if (!ValidChar(s[left]))
            {
                left++;
                continue;
            }

            if (!ValidChar(s[right]))
            {
                right--;
                continue;
            }

            if (!IgnoreCaseCompareChar(s[left], s[right])) return false;

            left++;
            right--;
        }

        return true;
    }

    private bool ValidChar(char c)
    {
        return (c >= '0' && c <= '9') || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
    }

    private bool IgnoreCaseCompareChar(char a, char b)
    {
        if (a >= 'A' && a <= 'Z') a = (char)(a + 32);

        if (b >= 'A' && b <= 'Z') b = (char)(b + 32);

        return a == b;
    }
}
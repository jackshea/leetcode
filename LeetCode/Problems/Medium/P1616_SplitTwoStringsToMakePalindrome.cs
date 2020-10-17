namespace LeetCode.Problems.Medium
{
    /// 分割两个字符串得到回文串
    /// https://leetcode-cn.com/problems/split-two-strings-to-make-palindrome/
    public class P1616_SplitTwoStringsToMakePalindrome
    {
        public bool CheckPalindromeFormation(string a, string b)
        {
            return Check(a, b) || Check(b, a);
        }

        private bool IsPalindrome(string a, int left, int right)
        {
            while (left < right)
            {
                if (a[left] != a[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        private bool Check(string a, string b)
        {
            int left = 0, right = a.Length - 1;
            while (left < right)
            {
                if (a[left] != b[right])
                {
                    return IsPalindrome(a, left, right) || IsPalindrome(b, left, right);
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
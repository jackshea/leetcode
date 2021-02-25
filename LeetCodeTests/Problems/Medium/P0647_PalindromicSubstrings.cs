namespace LeetCode.Problems.Medium.Tests
{
    /// 回文子串
    /// https://leetcode-cn.com/problems/palindromic-substrings/
    public class P0647_PalindromicSubstrings
    {
        public int CountSubstrings(string s)
        {
            var n = s.Length;
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                int left = i, right = i;
                while (left >= 0 && right < n)
                {
                    if (s[left--] == s[right++])
                    {
                        ans++;
                    }
                    else
                    {
                        break;
                    }
                }

                left = i;
                right = i + 1;
                while (left >= 0 && right < n)
                {
                    if (s[left--] == s[right++])
                    {
                        ans++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return ans;
        }
    }
}
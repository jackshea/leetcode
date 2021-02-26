namespace LeetCode.Problems.Medium
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
                for (int j = 0; j < 2; j++)
                {
                    int left = i, right = i + j;
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
            }

            return ans;
        }
    }
}
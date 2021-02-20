using System.Collections.Generic;

namespace LeetCode.Contest.Biweekly.C046
{
    /// 最长的美好子字符串
    /// https://leetcode-cn.com/contest/biweekly-contest-46/problems/longest-nice-substring/
    public class P5668
    {
        public string LongestNiceSubstring(string s)
        {
            string ans = string.Empty;
            Dictionary<char, int> freq = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                freq.Clear();
                for (int j = i; j < s.Length; j++)
                {
                    freq.TryGetValue(s[j], out var count);
                    freq[s[j]] = count + 1;
                    if (j - i >= 1)
                    {
                        bool check = true;
                        foreach (var kvp in freq)
                        {
                            if (!freq.ContainsKey((char)(kvp.Key - 32)) && !freq.ContainsKey((char)(kvp.Key + 32)))
                            {
                                check = false;
                            }
                        }
                        if (check && j - i + 1 > ans.Length)
                        {
                            ans = s.Substring(i, j - i + 1);
                        }
                    }
                }
            }

            return ans;
        }
    }
}
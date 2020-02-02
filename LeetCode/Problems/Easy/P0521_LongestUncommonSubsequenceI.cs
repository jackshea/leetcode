using System;

namespace LeetCode.Problems.Easy
{
    /// 最长特殊序列 Ⅰ
    /// https://leetcode-cn.com/problems/longest-uncommon-subsequence-i/
    public class P0521_LongestUncommonSubsequenceI
    {
        public int FindLUSlength(string a, string b)
        {
            if (a == b)
            {
                return -1;
            }

            return Math.Max(a.Length, b.Length);
        }
    }
}
using System;
using System.Linq;

namespace LeetCode.Problems
{
    ///  “气球” 的最大数量
    /// https://leetcode-cn.com/problems/maximum-number-of-balloons/
    public class P1189_MaximumNumberOfBalloons
    {
        public int MaxNumberOfBalloons(string text)
        {
            int[] cc = new int[26];
            foreach (var c in text)
            {
                cc[c - 'a']++;
            }

            return new int[] { cc[0], cc[1], cc['l' - 'a'] / 2, cc['o' - 'a'] / 2, cc['n' - 'a'] }.Min();
        }
    }
}
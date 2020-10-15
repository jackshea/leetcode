﻿using System;

namespace LeetCode.Problems.Medium
{
    /// 替换后的最长重复字符
    /// https://leetcode-cn.com/problems/longest-repeating-character-replacement/
    public class P0424_LongestRepeatingCharacterReplacement
    {
        public int CharacterReplacement(string s, int k)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int[] cc = new int[26];
            int left = 0;
            int maxCount = 0;
            for (int right = 0; right < s.Length; right++)
            {
                int cur = s[right] - 'A';
                cc[cur]++;
                maxCount = Math.Max(maxCount, cc[cur]);
                // 平移
                if (right - left + 1 > maxCount + k)
                {
                    cc[s[left] - 'A']--;
                    left++;
                }
            }

            return s.Length - left;
        }
    }
}
using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 所有子字符串美丽值之和
    /// https://leetcode.cn/problems/sum-of-beauty-of-all-substrings/
    public class P1781_SumOfBeautyOfAllSubstrings
    {
        public int BeautySum(string s)
        {
            var ans = 0;
            var charCnt = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                for (int ci = 0; ci < charCnt.Length; ci++)
                {
                    charCnt[ci] = 0;
                }

                int max = 0;
                for (int j = i ; j < s.Length; j++)
                {
                    int min = s.Length;
                    int idx = s[j] - 'a';
                    charCnt[idx]++;
                    max = Math.Max(max, charCnt[idx]);
                    for (int k = 0; k < charCnt.Length; k++)
                    {
                        if (charCnt[k] != 0)
                        {
                            min = Math.Min(min, charCnt[k]);
                        }
                    }
                    ans += max - min;
                }
            }

            return ans;
        }
    }
}
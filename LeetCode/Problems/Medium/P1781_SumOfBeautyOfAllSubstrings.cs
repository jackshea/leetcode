using System;

namespace LeetCode.Problems.Medium;

/// 所有子字符串美丽值之和
/// https://leetcode.cn/problems/sum-of-beauty-of-all-substrings/
public class P1781_SumOfBeautyOfAllSubstrings
{
    public int BeautySum(string s)
    {
        var ans = 0;
        var charCnt = new int[26];
        for (var i = 0; i < s.Length; i++)
        {
            for (var ci = 0; ci < charCnt.Length; ci++) charCnt[ci] = 0;

            var max = 0;
            for (var j = i; j < s.Length; j++)
            {
                var min = s.Length;
                var idx = s[j] - 'a';
                charCnt[idx]++;
                max = Math.Max(max, charCnt[idx]);
                for (var k = 0; k < charCnt.Length; k++)
                    if (charCnt[k] != 0)
                        min = Math.Min(min, charCnt[k]);
                ans += max - min;
            }
        }

        return ans;
    }
}
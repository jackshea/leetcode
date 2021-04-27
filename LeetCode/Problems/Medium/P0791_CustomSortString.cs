using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 自定义字符串排序
    /// https://leetcode-cn.com/problems/custom-sort-string/
    public class P0791_CustomSortString
    {
        public string CustomSortString(string S, string T)
        {
            Dictionary<char, int> sortIndex = new Dictionary<char, int>();
            for (int i = 0; i < S.Length; i++)
            {
                sortIndex[S[i]] = i;
            }

            var charArray = T.ToCharArray();
            Array.Sort(charArray, (a, b) =>
            {
                int aIndex;
                if (!sortIndex.TryGetValue(a, out aIndex))
                {
                    aIndex = T.Length;
                }
                int bIndex;
                if (!sortIndex.TryGetValue(b, out bIndex))
                {
                    bIndex = T.Length;
                }
                return aIndex.CompareTo(bIndex);
            });
            return new string(charArray);
        }
    }
}
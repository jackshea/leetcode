using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 查找常用字符
    /// https://leetcode-cn.com/problems/find-common-characters/
    public class P1002_FindCommonCharacters
    {
        public IList<string> CommonChars(string[] A)
        {
            int[] result = null;
            foreach (var a in A)
            {
                var chars = new int[26];
                foreach (var c in a)
                {
                    chars[c - 'a']++;
                }

                if (result == null)
                {
                    result = chars;
                }
                else
                {
                    for (int i = 0; i < 26; i++)
                    {
                        result[i] = Math.Min(result[i], chars[i]);
                    }
                }

            }

            IList<string> ans = new List<string>();
            for (var index = 0; index < result.Length; index++)
            {
                var n = result[index];
                for (int i = 0; i < n; i++)
                {

                    ans.Add(((char)('a' + index)).ToString());
                }
            }

            return ans;
        }
    }
}
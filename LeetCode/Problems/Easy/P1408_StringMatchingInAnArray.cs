using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 数组中的字符串匹配
    /// https://leetcode-cn.com/problems/string-matching-in-an-array/
    public class P1408_StringMatchingInAnArray
    {
        public IList<string> StringMatching(string[] words)
        {
            IList<string> ans = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[i].Length >= words[j].Length)
                    {
                        continue;
                    }

                    if (words[j].IndexOf(words[i]) != -1)
                    {
                        ans.Add(words[i]);
                        break;
                    }
                }
            }

            return ans;
        }
    }
}
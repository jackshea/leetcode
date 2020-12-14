using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 通过删除字母匹配到字典里最长单词
    /// https://leetcode-cn.com/problems/longest-word-in-dictionary-through-deleting/
    public class P0524_LongestWordInDictionaryThroughDeleting
    {
        public string FindLongestWord(string s, IList<string> d)
        {
            string ans = "";
            foreach (var dic in d)
            {
                if (IsSubsequence(dic, s))
                {
                    if (dic.Length > ans.Length || dic.Length == ans.Length && string.Compare(dic, ans) < 0)
                    {
                        ans = dic;
                    }
                }
            }

            return ans;
        }

        private bool IsSubsequence(string sub, string target)
        {
            int subIdx = 0;
            for (int i = 0; i < target.Length; i++)
            {
                if (subIdx == sub.Length)
                {
                    break;
                }

                if (target[i] == sub[subIdx])
                {
                    subIdx++;
                }
            }

            return subIdx == sub.Length;
        }
    }
}
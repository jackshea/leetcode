using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 去除重复字母
    /// https://leetcode-cn.com/problems/remove-duplicate-letters/
    public class P0316_RemoveDuplicateLetters
    {
        public string RemoveDuplicateLetters(string s)
        {
            int[] charCnt = new int[26];
            foreach (var c in s)
            {
                charCnt[c - 'a']++;
            }
            Stack<char> stack = new Stack<char>();
            bool[] exist = new bool[26];
            foreach (var c in s)
            {
                charCnt[c - 'a']--;
                if (exist[c - 'a'])
                {
                    continue;
                }

                while (stack.Count > 0 && stack.Peek() > c && charCnt[stack.Peek() - 'a'] > 0)
                {
                    exist[stack.Pop() - 'a'] = false;
                }
                stack.Push(c);
                exist[c - 'a'] = true;
            }

            char[] ans = new char[stack.Count];
            for (int i = ans.Length - 1; i >= 0; i--)
            {
                ans[i] = stack.Pop();
            }
            return new string(ans);
        }
    }
}
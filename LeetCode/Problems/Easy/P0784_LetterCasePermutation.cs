using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 字母大小写全排列
    /// https://leetcode-cn.com/problems/letter-case-permutation/
    public class P0784_LetterCasePermutation
    {
        private IList<string> ans = new List<string>();
        private char[] chars;

        public IList<string> LetterCasePermutation(string S)
        {
            chars = S.ToCharArray();
            Permutation(0);
            return ans;
        }

        private void Permutation(int start)
        {
            if (start >= chars.Length)
            {
                ans.Add(new string(chars));
                return;
            }

            Permutation(start + 1);

            if (!char.IsDigit(chars[start]))
            {
                chars[start] = CapsSwitch(chars[start]);
                Permutation(start + 1);
            }
        }

        /// 大小写转换
        private char CapsSwitch(char c)
        {
            return (char)(c ^ 32);
        }
    }
}
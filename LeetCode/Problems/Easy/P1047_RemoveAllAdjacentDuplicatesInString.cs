using System;

namespace LeetCode.Problems
{
    /// 删除字符串中的所有相邻重复项
    /// https://leetcode-cn.com/problems/remove-all-adjacent-duplicates-in-string/
    public class P1047_RemoveAllAdjacentDuplicatesInString
    {
        public string RemoveDuplicates(string S)
        {
            int len = S.Length;
            var charArray = S.ToCharArray();
            int curIndex = S.Length;
            while (curIndex >= 0)
            {
                if (curIndex >= len - 1)
                {
                    curIndex--;
                    continue;
                }

                if (charArray[curIndex] == charArray[curIndex + 1])
                {
                    for (int j = curIndex + 2; j < len; j++)
                    {
                        charArray[j - 2] = charArray[j];
                    }

                    len -= 2;
                }

                curIndex--;
            }

            return new string(charArray, 0, len);
        }
    }
}
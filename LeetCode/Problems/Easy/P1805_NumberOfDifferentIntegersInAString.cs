using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 字符串中不同整数的数目
    /// https://leetcode-cn.com/problems/number-of-different-integers-in-a-string/
    public class P1805_NumberOfDifferentIntegersInAString
    {
        public int NumDifferentIntegers(string word)
        {
            HashSet<string> numbers = new HashSet<string>();
            int start = 0, len = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    len++;
                }
                else
                {
                    if (len != 0)
                    {
                        while (len > 0 && word[start] == '0')
                        {
                            start++;
                            len--;
                        }
                        numbers.Add(word.Substring(start, len));
                    }
                    start = i + 1;
                    len = 0;
                }
            }
            if (len != 0)
            {
                while (len > 0 && word[start] == '0')
                {
                    start++;
                    len--;
                }
                numbers.Add(word.Substring(start, len));
            }

            return numbers.Count;
        }
    }
}
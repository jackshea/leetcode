using System;
using System.Text;

namespace LeetCode.Problems.Easy
{
    /// 上升下降字符串
    /// https://leetcode-cn.com/problems/increasing-decreasing-string/
    public class P1370_IncreasingDecreasingString
    {
        public string SortString(string s)
        {
            bool[] selected = new bool[s.Length];
            var ss = s.ToCharArray();
            Array.Sort(ss);
            StringBuilder ans = new StringBuilder();
            char minChar = (char)('a' - 1);
            char maxChar = (char)('z' + 1);
            char lastChar = minChar;
            bool isIncrease = true;
            while (ans.Length < ss.Length)
            {
                if (isIncrease)
                {
                    for (int i = 0; i < ss.Length; i++)
                    {
                        if (selected[i])
                        {
                            continue;
                        }

                        if (lastChar < ss[i])
                        {
                            ans.Append(ss[i]);
                            lastChar = ss[i];
                            selected[i] = true;
                        }
                    }

                    isIncrease = false;
                    lastChar = maxChar;
                }
                else
                {
                    for (int i = ss.Length - 1; i >= 0; i--)
                    {
                        if (selected[i])
                        {
                            continue;
                        }

                        if (lastChar > ss[i])
                        {
                            ans.Append(ss[i]);
                            lastChar = ss[i];
                            selected[i] = true;
                        }
                    }

                    isIncrease = true;
                    lastChar = minChar;
                }
            }

            return ans.ToString();
        }
    }
}
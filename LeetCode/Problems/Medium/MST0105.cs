using System;

namespace LeetCode.Problems.Medium
{
    /// 一次编辑
    /// https://leetcode-cn.com/problems/one-away-lcci/
    public class MST0105
    {
        public bool OneEditAway(string first, string second)
        {
            if (Math.Abs(first.Length - second.Length) > 1)
            {
                return false;
            }

            int i = 0, j = 0;
            int editLength = 0;
            while (i < first.Length && j < second.Length)
            {
                if (first[i] == second[j])
                {
                    i++;
                    j++;
                    continue;
                }

                if (++editLength > 1)
                {
                    return false;
                }

                if (first.Length == second.Length)
                {
                    if (i == first.Length - 1 && j == second.Length - 1)
                    {
                        return true;
                    }

                    if (first[i + 1] == second[j + 1])
                    {
                        i++;
                        j++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (first.Length > second.Length)
                {
                    if (first[i + 1] == second[j])
                    {
                        i++;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (first[i] == second[j + 1])
                    {
                        j++;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
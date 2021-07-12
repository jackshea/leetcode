﻿using System.Text;

namespace LeetCode.Problems.Medium
{
    /// 推多米诺
    /// https://leetcode-cn.com/problems/push-dominoes/
    public class P0838_PushDominoes
    {
        public string PushDominoes(string dominoes)
        {
            int[] directions = new int[dominoes.Length];
            int right = 0;
            for (int i = 0; i < dominoes.Length; i++)
            {
                char c = dominoes[i];
                if (c == 'R')
                {
                    right = 1;
                }
                else if (c == 'L')
                {
                    right = 0;
                }
                else
                {
                    if (right > 0)
                    {
                        right++;
                    }
                }

                directions[i] = right;
            }

            int left = 0;
            for (int i = dominoes.Length - 1; i >= 0; i--)
            {
                char c = dominoes[i];
                if (c == 'L')
                {
                    left = -1;
                    directions[i] = left;
                }
                else if (c == 'R')
                {
                    left = 0;
                    continue;
                }
                else if (left < 0)
                {
                    left--;
                    if (directions[i] != 0)
                    {
                        var sum = left + directions[i];
                        if (sum == 1)
                        {
                            directions[i] = left;
                            left = 0;
                            continue;
                        }
                        else if (sum <= 0)
                        {
                            left = 0;
                        }
                    }
                    directions[i] = left;
                }
            }

            StringBuilder sb = new StringBuilder(dominoes.Length);
            foreach (var direction in directions)
            {
                if (direction == 0)
                {
                    sb.Append('.');
                }
                else
                {
                    sb.Append(direction > 0 ? 'R' : 'L');
                }
            }

            return sb.ToString();
        }
    }
}
﻿using System;

namespace LeetCode.Problems
{
    /// 字符的最短距离
    /// https://leetcode-cn.com/problems/shortest-distance-to-a-character/
    public class P0821_ShortestDistanceToACharacter
    {
        public int[] ShortestToChar(string S, char C)
        {
            int dist = S.Length;
            int[] dists = new int[S.Length];
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                {
                    dist = 0;
                }

                dists[i] = dist;
                dist++;
            }

            dist = S.Length;
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == C)
                {
                    dist = 0;
                }

                dists[i] = Math.Min(dists[i], dist);
                dist++;
            }

            return dists;
        }
    }
}
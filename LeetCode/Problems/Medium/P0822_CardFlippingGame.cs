using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 翻转卡片游戏
    /// https://leetcode-cn.com/problems/card-flipping-game/
    public class P0822_CardFlippingGame
    {
        public int Flipgame(int[] fronts, int[] backs)
        {
            HashSet<int> same = new HashSet<int>();
            for (int i = 0; i < fronts.Length; i++)
            {
                if (fronts[i] == backs[i])
                {
                    same.Add(fronts[i]);
                }
            }

            int min = int.MaxValue;
            for (int i = 0; i < fronts.Length; i++)
            {
                if (!same.Contains(fronts[i]))
                {
                    min = Math.Min(min, fronts[i]);
                }

                if (!same.Contains(backs[i]))
                {
                    min = Math.Min(min, backs[i]);
                }

            }

            return min == int.MaxValue ? 0 : min;
        }
    }
}
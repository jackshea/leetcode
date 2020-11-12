﻿using System;

namespace LeetCode.Problems.Medium
{
    /// 用 Rand7() 实现 Rand10()
    /// https://leetcode-cn.com/problems/implement-rand10-using-rand7/
    public class Solution : SolBase
    {
        public int Rand10()
        {
            int ans = 0;
            while (true)
            {
                ans = (Rand7() - 1) * 7 + Rand7();
                if (ans <= 40)
                {
                    break;
                }
            }

            return ans % 10 + 1;
        }
    }

    public class SolBase
    {
        private Random rand = new Random((int)DateTime.Now.Ticks);
        public int Rand7()
        {
            return rand.Next(1, 8);
        }
    }
}
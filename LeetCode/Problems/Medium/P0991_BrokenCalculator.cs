using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 坏了的计算器
    /// https://leetcode-cn.com/problems/broken-calculator/
    public class P0991_BrokenCalculator
    {
        public int BrokenCalc(int X, int Y)
        {
            int ans = 0;
            while (X < Y)
            {
                ans++;
                if (Y % 2 == 1)
                {
                    Y++;
                }
                else
                {
                    Y /= 2;
                }
            }

            return ans + X - Y;
        }
    }
}
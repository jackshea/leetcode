using System;

namespace LeetCode.Problems.Medium
{
    /// LCP 19. 秋叶收藏集
    /// https://leetcode-cn.com/problems/UlBDOe/
    public class LCP19
    {
        public int MinimumOperations(string leaves)
        {
            int a = leaves[0] == 'y' ? 1 : 0;
            int b = leaves.Length;
            int c = b;
            for (int i = 1; i < leaves.Length; i++)
            {
                var leaf = leaves[i];
                int isRed = leaf == 'r' ? 1 : 0;
                int isYellow = leaf == 'y' ? 1 : 0;
                if (i > 2)
                {
                    c = Math.Min(b, c) + isYellow;
                }
                b = Math.Min(a, b) + isRed;
                a = a + isYellow;
            }

            return c;
        }
    }
}
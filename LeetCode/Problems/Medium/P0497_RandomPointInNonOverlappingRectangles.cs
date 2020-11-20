using System;

namespace LeetCode.Problems.Medium.P0497
{
    /// 非重叠矩形中的随机点
    /// https://leetcode-cn.com/problems/random-point-in-non-overlapping-rectangles/
    public class Solution
    {
        private int[][] rects;
        private int[] pointCnt;
        private int sum;
        private Random rand;

        public Solution(int[][] rects)
        {
            this.rects = rects;
            pointCnt = new int[rects.Length];
            rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < rects.Length; i++)
            {
                var r = rects[i];
                pointCnt[i] = (r[2] - r[0] + 1) * (r[3] - r[1] + 1);
                sum += pointCnt[i];
            }
        }

        public int[] Pick()
        {
            var selected = RandomWithWeight(pointCnt, sum);
            var rect = rects[selected];
            int x = rand.Next(rect[0], rect[2] + 1);
            int y = rand.Next(rect[1], rect[3] + 1);
            return new[] { x, y };
        }

        /// 加权随机。返回随机到的索引
        private int RandomWithWeight(int[] weights, int wSum)
        {
            var randWeight = rand.Next(0, wSum);
            for (int i = weights.Length - 1; i >= 0; i--)
            {
                wSum -= weights[i];
                if (randWeight >= wSum)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
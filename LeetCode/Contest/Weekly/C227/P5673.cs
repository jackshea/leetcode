using System;

namespace LeetCode.Contest.Weekly.C227
{
    /// 移除石子的最大得分
    /// https://leetcode-cn.com/contest/weekly-contest-227/problems/maximum-score-from-removing-stones/
    public class P5673
    {
        public int MaximumScore(int a, int b, int c)
        {
            int[] heap = new[] { a, b, c };
            Array.Sort(heap);
            if (heap[0] + heap[1] <= heap[2])
            {
                return heap[0] + heap[1];
            }
            else
            {
                int min = Math.Min(heap[0], (heap[1] + heap[0] - heap[2]) / 2);
                return heap[2] + min;
            }
        }
    }
}
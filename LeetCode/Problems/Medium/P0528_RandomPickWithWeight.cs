using System;
using System.Linq;

namespace LeetCode.Problems.Medium.P0528
{
    /// 按权重随机选择
    /// https://leetcode-cn.com/problems/random-pick-with-weight/
    public class Solution
    {
        private int[] sumWeights;
        private int sum;
        private Random rand;

        public Solution(int[] w)
        {
            int s = 0;
            sumWeights = new int[w.Length];
            for (int i = 0; i < w.Length; i++)
            {
                s += w[i];
                sumWeights[i] = s;
            }
            sum = w.Sum();
            rand = new Random();
        }

        public int PickIndex()
        {
            var selected = rand.Next(sum);
            int left = 0, right = sumWeights.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (sumWeights[mid] <= selected)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }
    }
}
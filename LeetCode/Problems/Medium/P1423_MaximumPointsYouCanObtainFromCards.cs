using System;
using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 可获得的最大点数
    /// https://leetcode-cn.com/problems/maximum-points-you-can-obtain-from-cards/
    public class P1423_MaximumPointsYouCanObtainFromCards
    {
        public int MaxScore(int[] cardPoints, int k)
        {
            var sum = cardPoints.Sum();
            if (cardPoints.Length == k)
            {
                return sum;
            }
            int len = cardPoints.Length - k, min = int.MaxValue, rSum = 0;
            for (int i = 0; i < len; i++)
            {
                rSum += cardPoints[i];
            }
            for (int i = len; i < cardPoints.Length; i++)
            {
                min = Math.Min(min, rSum);
                rSum += cardPoints[i] - cardPoints[i - len];
            }
            min = Math.Min(min, rSum);
            return sum - min;
        }
    }
}
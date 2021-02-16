using System;

namespace LeetCode.Problems.Easy
{
    /// 可以形成最大正方形的矩形数目
    /// https://leetcode-cn.com/problems/number-of-rectangles-that-can-form-the-largest-square/
    public class P1725_NumberOfRectanglesThatCanFormTheLargestSquare
    {
        public int CountGoodRectangles(int[][] rectangles)
        {
            int maxLen = 0;
            int ans = 1;
            foreach (var rectangle in rectangles)
            {
                var min = Math.Min(rectangle[0], rectangle[1]);
                if (maxLen == min)
                {
                    ans++;
                }
                else if (maxLen < min)
                {
                    maxLen = min;
                    ans = 1;
                }
            }

            return ans;
        }
    }
}
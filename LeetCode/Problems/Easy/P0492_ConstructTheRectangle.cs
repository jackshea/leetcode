using System;

namespace LeetCode.Problems.Easy
{
    /// 构造矩形
    /// https://leetcode-cn.com/problems/construct-the-rectangle/submissions/
    public class P0492_ConstructTheRectangle
    {
        public int[] ConstructRectangle(int area)
        {
            int width = (int)Math.Sqrt(area);
            while (area % width != 0)
            {
                width--;
            }

            return new[] {area / width, width};
        }
    }
}
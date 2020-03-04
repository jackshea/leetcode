using System;

namespace LeetCode.Problems.Medium
{
    /// 盛最多水的容器
    /// https://leetcode-cn.com/problems/container-with-most-water/
    public class P0011_ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int area = (j - i) * Math.Min(height[i], height[j]);
                    if (maxArea < area)
                    {
                        maxArea = area;
                    }
                }
            }

            return maxArea;
        }
    }
}
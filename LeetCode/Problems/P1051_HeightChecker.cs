using System;

namespace LeetCode.Problems
{
    /// 高度检查器
    /// https://leetcode-cn.com/problems/height-checker/
    public class P1051_HeightChecker
    {
        public int HeightChecker(int[] heights)
        {
            var sort = new int[heights.Length];
            Array.Copy(heights, sort, heights.Length);
            Array.Sort(sort);
            int ans = 0;
            for (int i = 0; i < sort.Length; i++)
            {
                if (heights[i] != sort[i])
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}
using System;

namespace LeetCode.Problems.Medium
{
    /// 最多能完成排序的块
    /// https://leetcode-cn.com/problems/max-chunks-to-make-sorted/
    public class P0769_MaxChunksToMakeSorted
    {
        public int MaxChunksToSorted(int[] arr)
        {
            int max = 0;
            int ans = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i]);
                if (max==i)
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}
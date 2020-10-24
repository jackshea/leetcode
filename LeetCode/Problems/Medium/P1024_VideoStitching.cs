using System;

namespace LeetCode.Problems.Medium
{
    /// 视频拼接
    /// https://leetcode-cn.com/problems/video-stitching/
    public class P1024_VideoStitching
    {
        public int VideoStitching(int[][] clips, int T)
        {
            int ans = 0;
            Array.Sort(clips, (a, b) => a[0].CompareTo(b[0]));
            if (clips[0][0] != 0)
            {
                return -1;
            }

            int left = 0;
            int right = 0;
            while (right < T)
            {
                int max = 0;
                while (left < clips.Length && clips[left][0] <= right)
                {
                    max = Math.Max(max, clips[left][1]);
                    left++;
                }

                if (max <= right)
                {
                    return -1;
                }
                else
                {
                    right = max;
                }

                ans++;
            }

            return ans;
        }
    }
}
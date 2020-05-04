using System;

namespace LeetCode.Problems.Hard
{
    /// 跳跃游戏 II
    /// https://leetcode-cn.com/problems/jump-game-ii/
    public class P0045_JumpGameII
    {
        public int Jump(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return 0;
            }

            int steps = 0;
            int end = 0;
            int far = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i <= end)
                {
                    far = Math.Max(far, i + nums[i]);
                }

                if (i == end)
                {
                    end = far;
                    steps++;
                }

                if (end >= nums.Length - 1)
                {
                    break;
                }
            }

            return steps;
        }
    }
}
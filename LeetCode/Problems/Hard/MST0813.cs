using System;

namespace LeetCode.Problems.Hard
{
    /// 堆箱子
    /// https://leetcode-cn.com/problems/pile-box-lcci/
    public class MST0813
    {
        public int PileBox(int[][] box)
        {
            if (box == null || box.Length == 0)
            {
                return 0;
            }

            Array.Sort(box, (a, b) =>
            {
                if (a[0] == b[0])
                {
                    return -a[1].CompareTo(b[1]);
                }

                return a[0].CompareTo(b[0]);
            });

            int[] dp = new int[box.Length];
            dp[0] = box[0][2];
            int ans = dp[0];
            for (int i = 1; i < box.Length; i++)
            {
                var b = box[i];
                int max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (b[0] > box[j][0] && b[1] > box[j][1] && b[2] > box[j][2] && max < dp[j])
                    {
                        max = dp[j];
                    }
                }

                dp[i] = max + b[2];
                if (ans < dp[i])
                {
                    ans = dp[i];
                }
            }

            return ans;
        }
    }
}
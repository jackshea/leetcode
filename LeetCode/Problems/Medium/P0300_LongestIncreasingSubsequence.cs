namespace LeetCode.Problems.Medium
{
    /// 最长上升子序列
    /// https://leetcode-cn.com/problems/longest-increasing-subsequence/
    public class P0300_LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int[] dp = new int[nums.Length];
            dp[0] = 1;
            int ans = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                int max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j] && dp[j] > max)
                    {
                        max = dp[j];
                    }
                }

                dp[i] = max + 1;
                if (ans < dp[i])
                {
                    ans = dp[i];
                }
            }

            return ans;
        }
    }
}
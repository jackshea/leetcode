namespace LeetCode.Problems.Medium
{
    /// 汉明距离总和
    /// https://leetcode-cn.com/problems/total-hamming-distance/
    public class P0477_TotalHammingDistance
    {
        public int TotalHammingDistance(int[] nums)
        {
            int n = nums.Length;
            int[] bits = new int[31];
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                int idx = 0;
                while (num != 0)
                {
                    if (num % 2 != 0)
                    {
                        bits[idx]++;
                    }

                    num /= 2;
                    idx++;
                }
            }

            int ans = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                ans += bits[i] * (n - bits[i]);
            }

            return ans;
        }
    }
}
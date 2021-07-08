using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 和相同的二元子数组
    /// https://leetcode-cn.com/problems/binary-subarrays-with-sum/
    public class P0930_BinarySubarraysWithSum
    {
        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            int sum = 0;
            int ans = 0;
            freq[0] = 1;
            foreach (var num in nums)
            {
                sum += num;
                var cnt = 0;
                if (freq.TryGetValue(sum - goal, out cnt))
                {
                    ans += cnt;
                }

                freq.TryGetValue(sum, out cnt);
                freq[sum] = cnt + 1;
            }

            return ans;
        }
    }
}
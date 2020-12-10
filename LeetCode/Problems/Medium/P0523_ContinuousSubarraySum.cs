using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 连续的子数组和
    /// https://leetcode-cn.com/problems/continuous-subarray-sum/
    public class P0523_ContinuousSubarraySum
    {
        public bool CheckSubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> remainders = new Dictionary<int, int>();
            int sum = 0;
            remainders.Add(0, -1);
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                sum += num;
                if (k != 0)
                {
                    sum %= k;
                }

                if (remainders.TryGetValue(sum, out var index))
                {
                    if (i - index > 1)
                    {
                        return true;
                    }
                }
                else
                {
                    remainders.Add(sum, i);
                }
            }

            return false;
        }
    }
}
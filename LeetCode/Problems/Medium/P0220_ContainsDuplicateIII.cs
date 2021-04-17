using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 存在重复元素 III
    /// https://leetcode-cn.com/problems/contains-duplicate-iii/
    public class P0220_ContainsDuplicateIII
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            int n = nums.Length;
            Dictionary<long, long> map = new Dictionary<long, long>();
            long w = (long)t + 1;
            for (int i = 0; i < n; i++)
            {
                long id = GetID(nums[i], w);
                if (map.ContainsKey(id))
                {
                    return true;
                }
                if (map.ContainsKey(id - 1) && Math.Abs(nums[i] - map[id - 1]) < w)
                {
                    return true;
                }
                if (map.ContainsKey(id + 1) && Math.Abs(nums[i] - map[id + 1]) < w)
                {
                    return true;
                }
                map.Add(id, nums[i]);
                if (i >= k)
                {
                    map.Remove(GetID(nums[i - k], w));
                }
            }
            return false;
        }

        public long GetID(long x, long w)
        {
            return x >= 0 ? x / w : (x + 1) / w - 1;
        }
    }
}
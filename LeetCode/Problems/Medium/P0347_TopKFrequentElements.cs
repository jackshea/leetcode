using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 前 K 个高频元素
    /// https://leetcode-cn.com/problems/top-k-frequent-elements/
    public class P0347_TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> frequent = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                frequent.TryGetValue(num, out var count);
                frequent[num] = count + 1;
            }

            var keyList = frequent.Keys.ToList();
            keyList.Sort((a, b) => frequent[b].CompareTo(frequent[a]));
            return keyList.Take(k).ToArray();
        }
    }
}
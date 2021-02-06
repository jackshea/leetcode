using System.Collections.Generic;

namespace LeetCode.Contest.Biweekly.C045
{
    /// 唯一元素的和
    /// https://leetcode-cn.com/contest/biweekly-contest-45/problems/sum-of-unique-elements/
    public class P5657
    {
        public int SumOfUnique(int[] nums)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                counter.TryGetValue(num, out var cnt);
                counter[num] = cnt + 1;
            }

            int sum = 0;
            foreach (var kvp in counter)
            {
                if (kvp.Value == 1)
                {
                    sum += kvp.Key;
                }
            }

            return sum;
        }
    }
}
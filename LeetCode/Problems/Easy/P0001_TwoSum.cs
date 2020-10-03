using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 两数之和
    /// https://leetcode-cn.com/problems/two-sum/description/
    public class P0001_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic[nums[i]] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.TryGetValue(target - nums[i], out var index))
                {
                    if (i != index)
                    {
                        return new[] { i, index };
                    }
                }
            }
            return new int[2];
        }
    }
}
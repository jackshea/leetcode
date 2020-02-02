using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 存在重复元素 II
    /// https://leetcode-cn.com/problems/contains-duplicate-ii/submissions/
    public class P0219_ContainsDuplicateII
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> num2Index = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (num2Index.ContainsKey(nums[i]))
                {
                    if (i - num2Index[nums[i]] <= k)
                    {
                        return true;
                    }
                }

                num2Index[nums[i]] = i;
            }

            return false;
        }
    }
}
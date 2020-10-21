using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 数组中重复的数据
    /// https://leetcode-cn.com/problems/find-all-duplicates-in-an-array/
    public class P0442_FindAllDuplicatesInAnArray
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            IList<int> ans = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0)
                {
                    ans.Add(index + 1);
                }
                else
                {
                    nums[index] *= -1;
                }
            }

            return ans;
        }
    }
}
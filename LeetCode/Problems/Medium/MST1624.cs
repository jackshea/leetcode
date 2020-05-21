using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 数对和
    /// https://leetcode-cn.com/problems/pairs-with-sum-lcci/
    public class MST1624
    {
        public IList<IList<int>> PairSums(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> ans = new List<IList<int>>();
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == target)
                {
                    ans.Add(new List<int> { nums[left], nums[right] });
                    left++;
                    right--;
                    continue;
                }
                if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return ans;
        }
    }
}
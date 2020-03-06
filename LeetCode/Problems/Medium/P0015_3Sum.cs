using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 三数之和
    /// https://leetcode-cn.com/problems/3sum/
    public class P0015_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            if (nums == null || nums.Length < 3)
            {
                return ans;
            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length;)
            {
                var currNum = nums[i];
                if (currNum > 0)
                {
                    break;
                }

                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    var leftNum = nums[left];
                    var rightNum = nums[right];
                    int sum = currNum + leftNum + rightNum;
                    if (sum > 0)
                    {
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        ans.Add(new List<int> { currNum, leftNum, rightNum });
                        while (left <= right && nums[right] == rightNum)
                        {
                            right--;
                        }
                        while (left <= right && nums[left] == leftNum)
                        {
                            left++;
                        }
                    }
                }

                while (i < nums.Length && nums[i] == currNum)
                {
                    i++;
                }
            }

            return ans;
        }
    }
}
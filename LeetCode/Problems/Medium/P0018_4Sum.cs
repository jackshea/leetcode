﻿using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 四数之和
    /// https://leetcode-cn.com/problems/4sum/
    public class P0018_4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }

                    int left = j + 1;
                    int right = nums.Length - 1;
                    while (left < right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum > target)
                        {
                            right--;
                        }
                        else if (sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            ans.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            while (left < right && nums[left] == nums[left + 1])
                            {
                                left++;
                            }

                            while (left < right && nums[right] == nums[right - 1])
                            {
                                right--;
                            }

                            left++;
                            right--;
                        }
                    }
                }
            }

            return ans;
        }
    }
}
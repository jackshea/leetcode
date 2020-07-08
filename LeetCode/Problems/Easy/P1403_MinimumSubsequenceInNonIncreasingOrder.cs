using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy
{
    /// 非递增顺序的最小子序列
    /// https://leetcode-cn.com/problems/minimum-subsequence-in-non-increasing-order/
    public class P1403_MinimumSubsequenceInNonIncreasingOrder
    {
        public IList<int> MinSubsequence(int[] nums)
        {
            var halfSum = nums.Sum() / 2;
            Array.Sort(nums);
            int selectSum = 0;
            IList<int> ans = new List<int>();
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                selectSum += nums[i];
                ans.Add(nums[i]);
                if (selectSum > halfSum)
                {
                    break;
                }
            }

            return ans;
        }
    }
}
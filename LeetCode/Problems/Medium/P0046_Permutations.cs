using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 全排列
    /// https://leetcode-cn.com/problems/permutations/
    public class P0046_Permutations
    {
        private IList<IList<int>> ans = new List<IList<int>>();
        public IList<IList<int>> Permute(int[] nums)
        {
            DFS(nums, 0);
            return ans;
        }

        private void DFS(int[] nums, int i)
        {
            if (i >= nums.Length - 1)
            {
                ans.Add(new List<int>(nums));
                return;
            }

            for (int j = i; j < nums.Length; j++)
            {
                Swap(nums, i, j);
                DFS(nums, i + 1);
                Swap(nums, i, j);
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
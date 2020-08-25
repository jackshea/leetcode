using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 递增子序列
    /// https://leetcode-cn.com/problems/increasing-subsequences/
    public class P0491_IncreasingSubsequences
    {
        private IList<IList<int>> ans = new List<IList<int>>();
        private int n;
        private int[] nums;

        public IList<IList<int>> FindSubsequences(int[] nums)
        {
            this.nums = nums;
            n = nums.Length;
            DFS(0, int.MinValue, new List<int>());
            return ans;
        }

        private void DFS(int start, int last, IList<int> row)
        {
            if (start >= n)
            {
                if (row.Count >= 2)
                {
                    ans.Add(new List<int>(row));
                }

                return;
            }

            if (nums[start] >= last)
            {
                row.Add(nums[start]);
                DFS(start + 1, nums[start], row);
                row.RemoveAt(row.Count - 1);
            }

            if (nums[start] != last)
            {
                DFS(start + 1, last, row);
            }
        }
    }
}
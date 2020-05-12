using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 幂集
    /// https://leetcode-cn.com/problems/power-set-lcci/
    public class MST0804
    {
        private IList<IList<int>> ans;
        public IList<IList<int>> Subsets(int[] nums)
        {
            ans = new List<IList<int>>();
            ans.Add(new List<int>());
            Backtrack(nums, 0, new List<int>());
            return ans;
        }

        private void Backtrack(int[] nums, int start, List<int> selected)
        {
            if (start == nums.Length)
            {
                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                selected.Add(nums[i]);
                ans.Add(new List<int>(selected));
                Backtrack(nums, i + 1, selected);
                selected.RemoveAt(selected.Count - 1);
            }
        }
    }
}
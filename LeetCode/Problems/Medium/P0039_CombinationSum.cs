using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 组合总和
    /// https://leetcode-cn.com/problems/combination-sum/
    public class P0039_CombinationSum
    {
        private int[] candidates;
        private int target;
        private IList<IList<int>> ans;

        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            this.target = target;
            this.candidates = candidates;
            Array.Sort(candidates);
            ans = new List<IList<int>>();
            DFS(new List<int>(), 0, 0);
            return ans;
        }

        private void DFS(List<int> selected, int startIndex, int sum)
        {
            if (sum > target)
            {
                return;
            }

            if (sum == target)
            {
                ans.Add(new List<int>(selected));
            }

            for (var i = startIndex; i < candidates.Length; i++)
            {
                var candidate = candidates[i];
                selected.Add(candidate);
                sum += candidate;
                DFS(selected, i, sum);
                selected.RemoveAt(selected.Count - 1);
                sum -= candidate;
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 组合总和 II
    /// https://leetcode-cn.com/problems/combination-sum-ii/
    public class P0040_CombinationSumII
    {
        private int[] candidates;
        private int target;
        private IList<IList<int>> ans;

        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
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

                // 如果之前有和candidate值相同的，除非之前的都被选上，否则就要进行剪枝，防止重复
                bool needcut = false;
                for (int j = 1; i - j >= 0 && candidates[i - j] == candidates[i]; j++)
                {
                    if (j > selected.Count || candidates[i] != selected[selected.Count - j])
                    {
                        needcut = true;
                        break;
                    }
                }

                if (needcut)
                {
                    continue;
                }

                selected.Add(candidate);
                DFS(selected, i + 1, sum + candidate);
                selected.RemoveAt(selected.Count - 1);
            }
        }
    }
}
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 组合
    /// https://leetcode-cn.com/problems/combinations/
    public class P0077_Combinations
    {
        private IList<IList<int>> ans;
        private int k;
        private int n;

        public IList<IList<int>> Combine(int n, int k)
        {
            ans = new List<IList<int>>();
            this.k = k;
            this.n = n;
            DFS(1, new List<int>());
            return ans;
        }

        private void DFS(int start, List<int> row)
        {
            if (row.Count == k)
            {
                ans.Add(new List<int>(row));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                row.Add(i);
                DFS(i + 1, row);
                row.RemoveAt(row.Count - 1);
            }
        }
    }
}
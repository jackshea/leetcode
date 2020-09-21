using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 字典序排数
    /// https://leetcode-cn.com/problems/lexicographical-numbers/
    public class P0386_LexicographicalNumbers
    {
        private List<int> ans = new List<int>();
        private int max;

        public IList<int> LexicalOrder(int n)
        {
            max = n;
            DFS(0);
            return ans;
        }

        public void DFS(int start)
        {
            if (start > max)
            {
                return;
            }

            if (start > 0)
            {
                ans.Add(start);
            }

            start *= 10;
            for (int i = 0; i <= 9; i++)
            {
                if (start + i == 0)
                {
                    continue;
                }

                DFS(start + i);
            }
        }
    }
}
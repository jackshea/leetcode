using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// N皇后 II
    /// https://leetcode-cn.com/problems/n-queens-ii/
    public class P0052_NQueensII
    {
        private int[] queens;
        private HashSet<int> columns = new HashSet<int>();// 会被攻击的行
        private HashSet<int> bias1 = new HashSet<int>();// 会被攻击的斜线，左上-右下，差为定值
        private HashSet<int> bias2 = new HashSet<int>();// 会被攻击的斜线，右上-左下，和为定值
        private int ans=0;
        private int nn;

        public int TotalNQueens(int n)
        {
            nn = n;
            queens = new int[n];
            DFS(0);
            return ans;
        }

        private void DFS(int row)
        {
            if (row >= nn)
            {
                ans++;
                return;
            }

            for (int i = 0; i < nn; i++)
            {
                if (columns.Contains(i) || bias1.Contains(row - i) || bias2.Contains(row + i)) continue;
                queens[row] = i;
                columns.Add(i);
                bias1.Add(row - i);
                bias2.Add(row + i);
                DFS(row + 1);
                queens[row] = 0;
                columns.Remove(i);
                bias1.Remove(row - i);
                bias2.Remove(row + i);
            }
        }
    }
}
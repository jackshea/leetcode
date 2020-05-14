using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// 八皇后
    /// https://leetcode-cn.com/problems/eight-queens-lcci/
    public class MST0812
    {
        private int[] queens;
        private HashSet<int> col = new HashSet<int>(); // 会被攻击的列
        private HashSet<int> bias1 = new HashSet<int>(); // 会被攻击的斜线，左上-右下，差为定值
        private HashSet<int> bias2 = new HashSet<int>(); // 会被攻击的斜线，右上-左下，和为定值
        private IList<IList<string>> ans;
        public IList<IList<string>> SolveNQueens(int n)
        {
            queens = new int[n];
            ans = new List<IList<string>>();
            Backtrack(0);
            return ans;
        }

        private void Backtrack(int r)
        {
            if (r >= queens.Length)
            {
                ans.Add(GenerateAns());
                return;
            }

            for (int i = 0; i < queens.Length; i++)
            {
                if (col.Contains(i) || bias1.Contains(r + i) || bias2.Contains(r - i))
                {
                    continue;
                }

                queens[r] = i;
                col.Add(i);
                bias1.Add(r + i);
                bias2.Add(r - i);
                Backtrack(r + 1);
                queens[r] = 0;
                col.Remove(i);
                bias1.Remove(r + i);
                bias2.Remove(r - i);
            }
        }

        private IList<string> GenerateAns()
        {
            IList<string> oneAns = new List<string>();
            for (int i = 0; i < queens.Length; i++)
            {
                char[] chars = new char[queens.Length];
                for (int j = 0; j < queens.Length; j++)
                {
                    chars[j] = queens[i] == j ? 'Q' : '.';
                }
                oneAns.Add(new string(chars));
            }

            return oneAns;
        }
    }
}
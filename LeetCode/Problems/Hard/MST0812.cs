using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// 八皇后
/// https://leetcode-cn.com/problems/eight-queens-lcci/
public class MST0812
{
    private readonly HashSet<int> bias1 = new(); // 会被攻击的斜线，左上-右下，差为定值
    private readonly HashSet<int> bias2 = new(); // 会被攻击的斜线，右上-左下，和为定值
    private readonly HashSet<int> col = new(); // 会被攻击的列
    private IList<IList<string>> ans;
    private int[] queens;

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

        for (var i = 0; i < queens.Length; i++)
        {
            if (col.Contains(i) || bias1.Contains(r + i) || bias2.Contains(r - i)) continue;

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
        for (var i = 0; i < queens.Length; i++)
        {
            var chars = new char[queens.Length];
            for (var j = 0; j < queens.Length; j++) chars[j] = queens[i] == j ? 'Q' : '.';
            oneAns.Add(new string(chars));
        }

        return oneAns;
    }
}
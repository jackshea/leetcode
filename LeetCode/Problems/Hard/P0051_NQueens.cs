using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// N皇后
/// https://leetcode-cn.com/problems/n-queens/
public class P0051_NQueens
{
    private readonly IList<IList<string>> ans = new List<IList<string>>();
    private readonly HashSet<int> bias1 = new(); // 会被攻击的斜线，左上-右下，差为定值
    private readonly HashSet<int> bias2 = new(); // 会被攻击的斜线，右上-左下，和为定值
    private readonly HashSet<int> columns = new(); // 会被攻击的行
    private int nn;
    private int[] queens;

    public IList<IList<string>> SolveNQueens(int n)
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
            GenAns();
            return;
        }

        for (var i = 0; i < nn; i++)
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

    private void GenAns()
    {
        var oneAns = new List<string>();
        foreach (var queen in queens)
        {
            var line = new char[nn];
            for (var i = 0; i < nn; i++)
                if (i == queen)
                    line[i] = 'Q';
                else
                    line[i] = '.';
            oneAns.Add(new string(line));
        }

        ans.Add(oneAns);
    }
}
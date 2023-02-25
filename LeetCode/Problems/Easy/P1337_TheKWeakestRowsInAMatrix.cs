using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 方阵中战斗力最弱的 K 行
/// https://leetcode-cn.com/problems/the-k-weakest-rows-in-a-matrix/
public class P1337_TheKWeakestRowsInAMatrix
{
    public int[] KWeakestRows(int[][] mat, int k)
    {
        var ranks = new List<PowerAndIndex>();
        for (var i = 0; i < mat.Length; i++)
            ranks.Add(new PowerAndIndex
            {
                Power = GetPower(mat[i]),
                RawIndex = i
            });
        ranks.Sort((a, b) =>
        {
            if (a.Power != b.Power) return a.Power.CompareTo(b.Power);

            return a.RawIndex.CompareTo(b.RawIndex);
        });

        var ans = new int[k];
        for (var i = 0; i < k; i++) ans[i] = ranks[i].RawIndex;

        return ans;
    }

    public int GetPower(int[] row)
    {
        var count = 0;
        for (var i = 0; i < row.Length; i++)
            if (row[i] == 1)
                count++;

        return count;
    }

    public class PowerAndIndex
    {
        public int Power;
        public int RawIndex;
    }
}
using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium.P0519;

/// 随机翻转矩阵
/// https://leetcode-cn.com/problems/random-flip-matrix/
public class Solution
{
    private readonly int cols;
    private readonly Dictionary<int, int> map = new();
    private readonly Random rand = new();
    private readonly int rows;
    private int poolLen;

    public Solution(int n_rows, int n_cols)
    {
        rows = n_rows;
        cols = n_cols;
        Reset();
    }

    public int[] Flip()
    {
        var selectIndex = rand.Next(poolLen--);
        if (!map.TryGetValue(selectIndex, out var selectValue)) selectValue = selectIndex;

        if (!map.TryGetValue(poolLen, out var end)) end = poolLen;

        map[selectIndex] = end;
        return new[] { selectValue / cols, selectValue % cols };
    }

    public void Reset()
    {
        map.Clear();
        poolLen = rows * cols;
    }
}
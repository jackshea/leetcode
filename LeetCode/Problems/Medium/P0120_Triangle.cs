using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 三角形最小路径和
/// https://leetcode-cn.com/problems/triangle/
/// 从下往上递推
public class P0120_Triangle
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        var n = triangle.Count;
        var min = new int[n];
        var endLine = triangle[n - 1];
        for (var i = 0; i < endLine.Count; i++) min[i] = endLine[i];

        for (var i = triangle.Count - 2; i >= 0; i--)
        for (var j = 0; j < triangle[i].Count; j++)
            min[j] = triangle[i][j] + Math.Min(min[j], min[j + 1]);

        return min[0];
    }
}
using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 杨辉三角 II
/// https://leetcode-cn.com/problems/pascals-triangle-ii/description/
public class P0119_PascalsTriangleII
{
    public IList<int> GetRow(int rowIndex)
    {
        if (rowIndex < 0) return null;

        var result = new List<int>();
        long last = 1;
        result.Add(1);
        for (var i = 1; i <= rowIndex; i++)
        {
            last = last * (rowIndex - i + 1) / i;
            result.Add((int)last);
        }

        return result;
    }
}
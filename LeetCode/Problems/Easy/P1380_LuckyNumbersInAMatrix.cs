using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 矩阵中的幸运数
/// https://leetcode-cn.com/problems/lucky-numbers-in-a-matrix/
public class P1380_LuckyNumbersInAMatrix
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        IList<int> ans = new List<int>();
        var m = matrix.Length;
        var n = matrix[0].Length;
        var row = new int[m];
        var col = new int[n];
        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
        {
            if (matrix[i][j] < matrix[i][row[i]]) row[i] = j;

            if (matrix[i][j] > matrix[col[j]][j]) col[j] = i;
        }

        for (var i = 0; i < m; i++)
            if (i == col[row[i]])
                ans.Add(matrix[i][row[i]]);

        return ans;
    }
}
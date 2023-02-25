namespace LeetCode.Problems.Easy;

/// 奇数值单元格的数目
/// https://leetcode-cn.com/problems/cells-with-odd-values-in-a-matrix/
public class P1252_CellsWithOddValuesInAMatrix
{
    public int OddCells(int n, int m, int[][] indices)
    {
        var matrix = new int[n, m];
        foreach (var index in indices)
        {
            var r = index[0];
            var c = index[1];
            for (var i = 0; i < m; i++) matrix[r, i]++;

            for (var i = 0; i < n; i++) matrix[i, c]++;
        }

        var ans = 0;
        for (var i = 0; i < n; i++)
        for (var j = 0; j < m; j++)
            if (matrix[i, j] % 2 != 0)
                ans++;

        return ans;
    }
}
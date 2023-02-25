namespace LeetCode.Problems.Medium;

/// 搜索二维矩阵
/// https://leetcode-cn.com/problems/search-a-2d-matrix/
public class P0074_SearchA2dMatrix
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return false;

        var loRow = 0;
        var hiRow = matrix.Length - 1;
        while (loRow <= hiRow)
        {
            var mid = loRow + (hiRow - loRow) / 2;
            if (matrix[mid][0] < target)
                loRow = mid + 1;
            else if (matrix[mid][0] > target)
                hiRow = mid - 1;
            else
                return true;
        }

        if (hiRow < 0 || hiRow >= matrix.Length) return false;

        var row = matrix[hiRow];
        var lo = 0;
        var hi = row.Length - 1;
        while (lo <= hi)
        {
            var mid = lo + (hi - lo) / 2;
            if (row[mid] < target)
                lo = mid + 1;
            else if (row[mid] > target)
                hi = mid - 1;
            else
                return true;
        }

        return false;
    }
}
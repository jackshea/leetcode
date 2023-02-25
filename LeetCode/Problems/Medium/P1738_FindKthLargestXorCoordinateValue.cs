using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 找出第 K 大的异或坐标值
/// https://leetcode-cn.com/problems/find-kth-largest-xor-coordinate-value/
public class P1738_FindKthLargestXorCoordinateValue
{
    public int KthLargestValue(int[][] matrix, int k)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var dp = new int[m + 1, n + 1];
        var res = new List<int>();
        for (var i = 1; i <= m; i++)
        for (var j = 1; j <= n; j++)
        {
            dp[i, j] = dp[i - 1, j - 1] ^ dp[i, j - 1] ^ dp[i - 1, j] ^ matrix[i - 1][j - 1];
            res.Add(dp[i, j]);
        }

        res.Sort((a, b) => -a.CompareTo(b));
        return res[k - 1];
    }
}
using System;

namespace LeetCode.Problems.Medium;

/// 图像重叠
/// https://leetcode-cn.com/problems/image-overlap/
public class P0835_ImageOverlap
{
    public int LargestOverlap(int[][] img1, int[][] img2)
    {
        var n = img1.Length;
        var delta = new int[2 * n + 1, 2 * n + 1];
        for (var i = 0; i < n; i++)
        for (var j = 0; j < n; j++)
            if (img1[i][j] == 1)
                for (var k = 0; k < n; k++)
                for (var l = 0; l < n; l++)
                    if (img2[k][l] == 1)
                        delta[i - k + n, j - l + n]++;

        var ans = 0;
        for (var i = 0; i < delta.GetLength(0); i++)
        for (var j = 0; j < delta.GetLength(1); j++)
            ans = Math.Max(ans, delta[i, j]);

        return ans;
    }
}
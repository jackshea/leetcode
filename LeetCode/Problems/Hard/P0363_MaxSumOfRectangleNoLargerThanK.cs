using System;

namespace LeetCode.Problems.Hard;

/// 矩形区域不超过 K 的最大数值和
/// https://leetcode-cn.com/problems/max-sum-of-rectangle-no-larger-than-k/
public class P0363_MaxSumOfRectangleNoLargerThanK
{
    public int MaxSumSubmatrix(int[][] matrix, int k)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        var max = int.MinValue;
        for (var i = 0; i < cols; i++)
        {
            var rowSum = new int[rows];
            for (var j = i; j < cols; j++)
            {
                for (var m = 0; m < rows; m++) rowSum[m] += matrix[m][j];

                max = Math.Max(max, DpMax(rowSum, k));
                if (max == k) return k;
            }
        }

        return max;
    }

    private int DpMax(int[] arr, int k)
    {
        int rollSum = arr[0], rollMax = rollSum;
        // O(rows)
        for (var i = 1; i < arr.Length; i++)
        {
            if (rollSum > 0) rollSum += arr[i];
            else rollSum = arr[i];
            if (rollSum > rollMax) rollMax = rollSum;
        }

        if (rollMax <= k) return rollMax;
        // O(rows ^ 2)
        var max = int.MinValue;
        for (var l = 0; l < arr.Length; l++)
        {
            var sum = 0;
            for (var r = l; r < arr.Length; r++)
            {
                sum += arr[r];
                if (sum > max && sum <= k) max = sum;
                if (max == k) return k; // 尽量提前
            }
        }

        return max;
    }
}
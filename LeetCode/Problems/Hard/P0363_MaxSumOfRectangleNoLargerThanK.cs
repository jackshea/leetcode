using System;

namespace LeetCode.Problems.Hard
{
    /// 矩形区域不超过 K 的最大数值和
    /// https://leetcode-cn.com/problems/max-sum-of-rectangle-no-larger-than-k/
    public class P0363_MaxSumOfRectangleNoLargerThanK
    {
        public int MaxSumSubmatrix(int[][] matrix, int k)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int max = int.MinValue;
            for (int i = 0; i < cols; i++)
            {
                int[] rowSum = new int[rows];
                for (int j = i; j < cols; j++)
                {
                    for (int m = 0; m < rows; m++)
                    {
                        rowSum[m] += matrix[m][j];
                    }

                    max = Math.Max(max, DpMax(rowSum, k));
                    if (max == k)
                    {
                        return k;
                    }
                }
            }

            return max;
        }

        private int DpMax(int[] arr, int k)
        {
            int rollSum = arr[0], rollMax = rollSum;
            // O(rows)
            for (int i = 1; i < arr.Length; i++)
            {
                if (rollSum > 0) rollSum += arr[i];
                else rollSum = arr[i];
                if (rollSum > rollMax) rollMax = rollSum;
            }
            if (rollMax <= k) return rollMax;
            // O(rows ^ 2)
            int max = int.MinValue;
            for (int l = 0; l < arr.Length; l++)
            {
                int sum = 0;
                for (int r = l; r < arr.Length; r++)
                {
                    sum += arr[r];
                    if (sum > max && sum <= k) max = sum;
                    if (max == k) return k; // 尽量提前
                }
            }
            return max;
        }
    }
}
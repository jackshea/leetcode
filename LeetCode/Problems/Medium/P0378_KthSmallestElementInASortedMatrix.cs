namespace LeetCode.Problems.Medium;

/// 有序矩阵中第K小的元素
/// https://leetcode-cn.com/problems/kth-smallest-element-in-a-sorted-matrix/
public class P0378_KthSmallestElementInASortedMatrix
{
    public int KthSmallest(int[][] matrix, int k)
    {
        var n = matrix.Length;
        var left = matrix[0][0];
        var right = matrix[n - 1][n - 1];
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (check(matrix, k, mid))
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }

    private bool check(int[][] matrix, int k, int mid)
    {
        var n = matrix.Length;
        var r = n - 1;
        var c = 0;
        var count = 0;
        while (r >= 0 && c < n)
            if (matrix[r][c] <= mid)
            {
                count += r + 1;
                c++;
            }
            else
            {
                r--;
            }

        return count >= k;
    }
}
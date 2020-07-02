namespace LeetCode.Problems.Medium
{
    /// 有序矩阵中第K小的元素
    /// https://leetcode-cn.com/problems/kth-smallest-element-in-a-sorted-matrix/
    public class P0378_KthSmallestElementInASortedMatrix
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            int n = matrix.Length;
            int left = matrix[0][0];
            int right = matrix[n - 1][n - 1];
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (check(matrix, k, mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        private bool check(int[][] matrix, int k, int mid)
        {
            int n = matrix.Length;
            int r = n - 1;
            int c = 0;
            int count = 0;
            while (r >= 0 && c < n)
            {
                if (matrix[r][c] <= mid)
                {
                    count += r + 1;
                    c++;
                }
                else
                {
                    r--;
                }
            }

            return count >= k;
        }
    }
}
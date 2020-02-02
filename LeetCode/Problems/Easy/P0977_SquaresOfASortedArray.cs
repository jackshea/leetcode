using System;

namespace LeetCode.Problems.Easy
{
    /// 有序数组的平方
    /// https://leetcode-cn.com/problems/squares-of-a-sorted-array/
    public class P0977_SquaresOfASortedArray
    {
        public int[] SortedSquares(int[] A)
        {
            var ans = new int[A.Length];
            int left = 0, right = A.Length - 1;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (Math.Abs(A[left]) > Math.Abs(A[right]))
                {
                    ans[i] = A[left] * A[left];
                    left++;
                }
                else
                {
                    ans[i] = A[right] * A[right];
                    right--;
                }
            }

            return ans;
        }
    }
}
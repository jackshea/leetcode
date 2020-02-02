using System;

namespace LeetCode.Problems.Easy
{
    /// 三角形的最大周长
    /// https://leetcode-cn.com/problems/largest-perimeter-triangle/
    public class P0976_LargestPerimeterTriangle
    {
        public int LargestPerimeter(int[] A)
        {
            Array.Sort(A, (a, b) => -a.CompareTo(b));

            for (int i = 0; i < A.Length - 2; i++)
            {
                if (A[i + 1] + A[i + 2] > A[i])
                {
                    return A[i] + A[i + 1] + A[i + 2];
                }
            }

            return 0;
        }
    }
}
using System;

namespace LeetCode.Problems.Medium
{
    /// 使数组唯一的最小增量
    /// https://leetcode-cn.com/problems/minimum-increment-to-make-array-unique/
    public class P0945_MinimumIncrementToMakeArrayUnique
    {
        public int MinIncrementForUnique(int[] A)
        {
            if (A == null || A.Length <= 1)
            {
                return 0;
            }

            Array.Sort(A);
            int increment = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > A[i - 1])
                {
                    continue;
                }

                increment += A[i - 1] + 1 - A[i];
                A[i] = A[i - 1] + 1;
            }

            return increment;
        }
    }
}
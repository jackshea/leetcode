using System;

namespace LeetCode.Problems.Medium
{
    /// 旋转函数
    /// https://leetcode-cn.com/problems/rotate-function/
    public class P0396_RotateFunction
    {
        public int MaxRotateFunction(int[] A)
        {
            int sum = 0;
            int f = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                f += i * A[i];
            }

            int ans = 0;
            for (int i = 1; i < A.Length; i++)
            {
                f += sum - A.Length * A[A.Length - i];
                ans = Math.Max(ans, f);
            }

            return ans;
        }
    }
}
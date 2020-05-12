using System;

namespace LeetCode.Problems.Medium
{
    /// 递归乘法
    /// https://leetcode-cn.com/problems/recursive-mulitply-lcci/
    public class MST0805
    {
        public int Multiply(int A, int B)
        {
            if (B == 0) return 0;
            if (B == 1) return A;
            return (B % 2 == 0 ? 0 : A) + (Multiply(A, B >> 1) << 1);
        }
    }
}
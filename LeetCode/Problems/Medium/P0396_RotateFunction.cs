using System;

namespace LeetCode.Problems.Medium;

/// 旋转函数
/// https://leetcode-cn.com/problems/rotate-function/
public class P0396_RotateFunction
{
    public int MaxRotateFunction(int[] A)
    {
        var sum = 0;
        var f = 0;
        for (var i = 0; i < A.Length; i++)
        {
            sum += A[i];
            f += i * A[i];
        }

        var ans = f;
        for (var i = 1; i < A.Length; i++)
        {
            f += sum - A.Length * A[A.Length - i];
            ans = Math.Max(ans, f);
        }

        return ans;
    }
}
namespace LeetCode.Problems.Easy;

/// 单调数列
/// https://leetcode-cn.com/problems/monotonic-array/
public class P0896_MonotonicArray
{
    public bool IsMonotonic(int[] A)
    {
        var asc = true;
        var desc = true;
        for (var i = 0; i < A.Length - 1; i++)
        {
            if (A[i] < A[i + 1]) desc = false;

            if (A[i] > A[i + 1]) asc = false;
        }

        return asc || desc;
    }
}